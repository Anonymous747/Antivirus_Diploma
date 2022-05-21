using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using Antivirus.Model;
using System.Text;
using System.Diagnostics;
using Antivirus.Source;
using System.Linq;
using Antivirus.Source;

namespace Antivirus.Repository
{
    /// <summary>
    /// Reads in the header information of the Portable Executable format.
    /// Provides information such as the date the assembly was compiled.
    /// </summary>
    public class PeHeaderReader
    {
        #region Private Fields

        /// <summary>
        /// The file signature
        /// </summary>
        private IMAGE_DATA_SIGNATURE signature;
        /// <summary>
        /// The DOS header
        /// </summary>
        private IMAGE_DOS_HEADER dosHeader;
        /// <summary>
        /// The file header
        /// </summary>
        private IMAGE_FILE_HEADER fileHeader;
        /// <summary>
        /// Optional 32 bit file header 
        /// </summary>
        private IMAGE_OPTIONAL_HEADER32 optionalHeader32;
        /// <summary>
        /// Optional 64 bit file header 
        /// </summary>
        private IMAGE_OPTIONAL_HEADER64 optionalHeader64;
        /// <summary>
        /// Image Section headers. Number of sections is in the file header.
        /// </summary>
        private IMAGE_SECTION_HEADER imageSectionHeader;

        private EXTENDED_IMAGE_SECTION_HEADER[] extendedImageSectionHeaders;

        private SECTION_PROPS sectionProps;

        private String fileName;
        private String filePath;
        private bool isFileExecutable = true;

        private const int EXECUTABLE_FILE_NUMBER = 23117;

        #endregion Private Fields

        #region Public Methods

        public PeHeaderReader(string fullFilePath)
        {
            this.filePath = fullFilePath;
            this.fileName = filePath.GetFileName();

            // Read in the DLL or EXE and get the timestamp
            using (FileStream stream = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                BinaryReader reader = new BinaryReader(stream);
                /* var entropy = GetReaderBytes(reader).GetEntropy();

                 stream.Seek(0, SeekOrigin.Begin);*/

                dosHeader = FromBinaryReader<IMAGE_DOS_HEADER>(reader);

                // Is not a executable file
                if (dosHeader.e_magic != EXECUTABLE_FILE_NUMBER)
                {
                    isFileExecutable = false;
                    return;
                }

                // Add 4 bytes to the offset
                stream.Seek(dosHeader.e_lfanew, SeekOrigin.Begin);

                signature = FromBinaryReader<IMAGE_DATA_SIGNATURE>(reader);
                fileHeader = FromBinaryReader<IMAGE_FILE_HEADER>(reader);

                if (this.Is32BitHeader)
                {
                    optionalHeader32 = FromBinaryReader<IMAGE_OPTIONAL_HEADER32>(reader);
                }
                else
                {
                    optionalHeader64 = FromBinaryReader<IMAGE_OPTIONAL_HEADER64>(reader);
                }

                extendedImageSectionHeaders = new EXTENDED_IMAGE_SECTION_HEADER[fileHeader.NumberOfSections];

                for (int headerNo = 0; headerNo < extendedImageSectionHeaders.Length; ++headerNo)
                {
                    byte[] bytes = GetBinaryReaderBytes<IMAGE_SECTION_HEADER>(reader);
                    var sectionEntropy = bytes.GetEntropy();
                    IMAGE_SECTION_HEADER sectionHeader = FromBytesToModel<IMAGE_SECTION_HEADER>(bytes);

                    extendedImageSectionHeaders[headerNo].sectionHeader = sectionHeader;
                    extendedImageSectionHeaders[headerNo].entropy = sectionEntropy;
                }

                var entropyies = extendedImageSectionHeaders.Select(s => s.entropy).ToList();
                sectionProps.meanEntropy = entropyies.GetAverageValue();
                sectionProps.minEntropy = entropyies.Min();
                sectionProps.maxEntropy = entropyies.Max();

                var rawSizes = extendedImageSectionHeaders.Select(s => s.sectionHeader.SizeOfRawData).ToList();
                sectionProps.meanRawSize = rawSizes.GetAverageValue();
                sectionProps.minRawSize = rawSizes.Min();
                sectionProps.maxRawSize = rawSizes.Max();

                var virtualSizes = extendedImageSectionHeaders.Select(s => s.sectionHeader.VirtualSize).ToList();
                sectionProps.meanVirtualSize = virtualSizes.GetAverageValue();
                sectionProps.minVirtualSize = virtualSizes.Min();
                sectionProps.maxVirtualSize = virtualSizes.Max();
            }
        }

        /// <summary>
        /// Gets the header of the .NET assembly that called this function
        /// </summary>
        /// <returns></returns>
        public static PeHeaderReader GetCallingAssemblyHeader()
        {
            // Get the path to the calling assembly, which is the path to the
            // DLL or EXE that we want the time of
            string filePath = System.Reflection.Assembly.GetCallingAssembly().Location;

            // Get and return the timestamp
            return new PeHeaderReader(filePath);
        }

        /// <summary>
        /// Gets the header of the .NET assembly that called this function
        /// </summary>
        /// <returns></returns>
        public static PeHeaderReader GetAssemblyHeader()
        {
            // Get the path to the calling assembly, which is the path to the
            // DLL or EXE that we want the time of
            string filePath = System.Reflection.Assembly.GetAssembly(typeof(PeHeaderReader)).Location;

            // Get and return the timestamp
            return new PeHeaderReader(filePath);
        }

        /// <summary>
        /// Reads in a block from a file and converts it to the struct
        /// type specified by the template parameter
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static T FromBinaryReader<T>(BinaryReader reader)
        {
            // Read in a byte array
            byte[] bytes = reader.ReadBytes(Marshal.SizeOf(typeof(T)));

            // Pin the managed memory while, copy it out the data, then unpin it
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            T theStructure = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();

            return theStructure;
        }

        public static byte[] GetBinaryReaderBytes<T>(BinaryReader reader)
        {
            // Read in a byte array
            return reader.ReadBytes(Marshal.SizeOf(typeof(T)));
        }

        public static T FromBytesToModel<T>(byte[] bytes)
        {
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            T theStructure = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();

            return theStructure;
        }

        private const int READ_BUFFER_SIZE = 1024;

        public static byte[] GetReaderBytes(BinaryReader reader)
        {
            int byteRead = 0;
            int byteTransfered = 0;
            byte[] fileBytes = new byte[0];
            do
            {
                byte[] buffer = reader.ReadBytes(READ_BUFFER_SIZE);
                byteRead = buffer.Length;
                byteTransfered += byteRead;
                fileBytes = fileBytes.Concat(buffer).ToArray();
            } while (byteRead == READ_BUFFER_SIZE);

            return fileBytes;
        }

        #endregion Public Methods

        #region Properties

        /// <summary>
        /// Gets if the file header is 32 bit or not
        /// </summary>
        public bool Is32BitHeader
        {
            get
            {
                UInt16 IMAGE_FILE_32BIT_MACHINE = 0x0100;
                return (IMAGE_FILE_32BIT_MACHINE & FileHeader.Characteristics) == IMAGE_FILE_32BIT_MACHINE;
            }
        }

        /// <summary>
        /// Gets the file header
        /// </summary>
        public IMAGE_FILE_HEADER FileHeader
        {
            get
            {
                return fileHeader;
            }
        }

        /// <summary>
        /// Gets the file signature
        /// </summary>
        public IMAGE_DATA_SIGNATURE FileSignature
        {
            get
            {
                return signature;
            }
        }

        /// <summary>
        /// Gets the optional header
        /// </summary>
        public IMAGE_OPTIONAL_HEADER32 OptionalHeader32
        {
            get
            {
                return optionalHeader32;
            }
        }

        /// <summary>
        /// Gets the optional header
        /// </summary>
        public IMAGE_OPTIONAL_HEADER64 OptionalHeader64
        {
            get
            {
                return optionalHeader64;
            }
        }

        public IMAGE_SECTION_HEADER ImageSectionHeader
        {
            get
            {
                return imageSectionHeader;
            }
        }

        public EXTENDED_IMAGE_SECTION_HEADER[] ExtendedImageSectionHeaders
        {
            get
            {
                return extendedImageSectionHeaders;
            }
        }

        /// <summary>
        /// Gets the timestamp from the file header
        /// </summary>
        public DateTime TimeStamp
        {
            get
            {
                // Timestamp is a date offset from 1970
                DateTime returnValue = new DateTime(1970, 1, 1, 0, 0, 0);

                // Add in the number of seconds since 1970/1/1
                returnValue = returnValue.AddSeconds(fileHeader.TimeDateStamp);
                // Adjust to local timezone
                returnValue += TimeZone.CurrentTimeZone.GetUtcOffset(returnValue);

                return returnValue;
            }
        }

        public bool IsFileExecutable { get { return isFileExecutable; } }

        #endregion Properties

        #region Reduction

        public PeFileModel ToModel(String name)
        {
            return this.Is32BitHeader ? Create32PeFileModel() : Create64PeFileModel();
        }

        public PeFileModel Create32PeFileModel()
        {
            return new PeFileModel(
                fileName, // Name
                    "", // md5
                    fileHeader.Machine,
                    fileHeader.SizeOfOptionalHeader,
                    fileHeader.Characteristics,
                    optionalHeader32.MajorLinkerVersion,
                    optionalHeader32.MinorLinkerVersion,
                     optionalHeader32.SizeOfCode,
                    optionalHeader32.SizeOfInitializedData,
                    optionalHeader32.SizeOfUninitializedData,
                    optionalHeader32.AddressOfEntryPoint,
                    optionalHeader32.BaseOfCode,
                    optionalHeader32.BaseOfData,
                    optionalHeader32.ImageBase,
                    optionalHeader32.SectionAlignment,
                    optionalHeader32.FileAlignment,
                    optionalHeader32.MajorOperatingSystemVersion,
                    optionalHeader32.MajorImageVersion,
                    optionalHeader32.MinorImageVersion,
                    optionalHeader32.MajorSubsystemVersion,
                    optionalHeader32.MinorOperatingSystemVersion,
                    optionalHeader32.MinorSubsystemVersion,
                   optionalHeader32.SizeOfImage,
                    optionalHeader32.SizeOfHeaders,
                    optionalHeader32.CheckSum,
                    optionalHeader32.Subsystem,
                    optionalHeader32.DllCharacteristics,
                    optionalHeader32.SizeOfStackReserve,
                    optionalHeader32.SizeOfStackCommit,
                    optionalHeader32.SizeOfHeapReserve,
                    optionalHeader32.SizeOfHeapCommit,
                    optionalHeader32.LoaderFlags,
                    optionalHeader32.NumberOfRvaAndSizes,
                    extendedImageSectionHeaders.Length, // SectionsNb
                    sectionProps.meanEntropy, // SectionMeanEntropy
                    sectionProps.minEntropy, // SectionsMinEntropy
                    sectionProps.maxEntropy, // SectionsMaxEntropy 
                    (int)sectionProps.meanRawSize, // SectionsMeanRawsize 
                    sectionProps.minRawSize, // SectionsMinRawsize 
                    sectionProps.maxRawSize, // SectionMaxRawsize 
                    (int)sectionProps.meanVirtualSize, // SectionsMeanVirtualsize
                    (int)sectionProps.minVirtualSize, // SectionsMinVirtualsize 
                    (int)sectionProps.maxVirtualSize, // SectionsMaxVirtualsize 
                    0, // ImportsNbDLL
                    0, // ImportsNb
                    0, // ImportsNbOrdinal
                    0, // ExportNb
                    0, // ResourcesNb
                    0, // ResourcesMeanEntropy
                    0, // ResourcesMinEntropy
                    0, // ResourcesMaxEntropy
                    0, // ResourcesMeanSize
                    0, // ResourcesMeanSize
                    0, // ResourcesMaxSize
                    0, // LoadConfigurationSize
                    0  //  VersionInformationSize

                );
        }

        public PeFileModel Create64PeFileModel()
        {
            return new PeFileModel(
                fileName, // Name
                    "", // md5
                    fileHeader.Machine,
                    fileHeader.SizeOfOptionalHeader,
                    fileHeader.Characteristics,
                    optionalHeader64.MajorLinkerVersion,
                    optionalHeader64.MinorLinkerVersion,
                     optionalHeader64.SizeOfCode,
                    optionalHeader64.SizeOfInitializedData,
                    optionalHeader64.SizeOfUninitializedData,
                    optionalHeader64.AddressOfEntryPoint,
                    optionalHeader64.BaseOfCode,
                    optionalHeader32.BaseOfData,
                    optionalHeader64.ImageBase,
                    optionalHeader64.SectionAlignment,
                    optionalHeader64.FileAlignment,
                    optionalHeader64.MinorOperatingSystemVersion,
                    optionalHeader64.MinorOperatingSystemVersion,
                    optionalHeader64.MajorImageVersion,
                    optionalHeader64.MinorImageVersion,
                    optionalHeader64.MajorSubsystemVersion,
                    optionalHeader64.MinorSubsystemVersion,
                    optionalHeader64.SizeOfImage,
                    optionalHeader64.SizeOfHeaders,
                    optionalHeader64.CheckSum,
                    optionalHeader64.Subsystem,
                    optionalHeader64.DllCharacteristics,
                    optionalHeader64.SizeOfStackReserve,
                    optionalHeader64.SizeOfStackCommit,
                    optionalHeader64.SizeOfHeapReserve,
                    optionalHeader64.SizeOfHeapCommit,
                    optionalHeader64.LoaderFlags,
                    optionalHeader64.NumberOfRvaAndSizes,
                    extendedImageSectionHeaders.Length, // SectionsNb
                    (int)sectionProps.meanRawSize, // SectionsMeanRawsize 
                    sectionProps.minRawSize, // SectionsMinRawsize 
                    sectionProps.maxRawSize, // SectionMaxRawsize 
                    (int)sectionProps.meanRawSize, // SectionsMeanRawsize 
                    sectionProps.minRawSize, // SectionsMinRawsize 
                    sectionProps.maxRawSize, // SectionMaxRawsize 
                    (int)sectionProps.meanVirtualSize, // 6762, // SectionsMeanVirtualsize
                    (int)sectionProps.minVirtualSize, // 103832, // SectionsMinVirtualsize 
                    (int)sectionProps.maxVirtualSize, // SectionsMaxVirtualsize
                    0, // 4, // ImportsNbDLL
                    0, // 106, // ImportsNb
                    0, // 2, // ImportsNbOrdinal
                    0, // ExportNb
                    0, // 6, // ResourcesNb
                    0, // 3, // ResourcesMeanEntropy
                    0, // 2, // ResourcesMinEntropy
                    0, // 1060, // ResourcesMaxEntropy
                    0, // 48, // ResourcesMeanSize
                    0, // 3752, // ResourcesMeanSize
                    0, // 72, // ResourcesMaxSize
                    0, // 16, // LoadConfigurationSize
                    0  //  VersionInformationSize
                ); ;
        }

        #endregion


    }
}

