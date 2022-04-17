using Antivirus.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antivirus.Model
{
    public struct PeFileModel
    {
        public PeFileModel(int name, string md5, ushort machine, ushort sizeOfOptionalHeader, ushort characteristics, byte majorLinkerVersion, byte minorLinkerVersion, uint sizeOfCode, uint sizeOfInitializedData, uint sizeOfUninitializedData, uint addressOfEntryPoint, uint baseOfCode, uint baseOfData, ulong imageBase, uint sectionAlignment, uint fileAlignment, ushort majorOperatingSystemVersion, ushort minorOperatingSystemVersion, ushort majorImageVersion, ushort minorImageVersion, ushort majorSubsystemVersion, ushort minorSubsystemVersion, uint sizeOfImage, uint sizeOfHeaders, uint checkSum, ushort subsystem, ushort dllCharacteristics, ulong sizeOfStackReserve, ulong sizeOfStackCommit, ulong sizeOfHeapReserve, ulong sizeOfHeapCommit, uint loaderFlags, uint numberOfRvaAndSizes, int sectionsNb, double sectionsMeanEntropy, double sectionsMinEntropy, double sectionsMaxEntropy, int sectionsMeanRawsize, double sectionsMinRawsize, double sectionMaxRawsize, int sectionsMeanVirtualsize, int sectionsMinVirtualsize, int importsNbDLL, int importsNb, int importsNbOrdinal, int exportNb, int resourcesNb, double resourcesMeanEntropy, double resourcesMinEntropy, double resourcesMaxEntropy, double resourcesMeanSize, int resourcesMinSize, int resourcesMaxSize, int loadConfigurationSize, int versionInformationSize)
        {
            Name = name;
            Md5 = md5;
            Machine = machine;
            SizeOfOptionalHeader = sizeOfOptionalHeader;
            Characteristics = characteristics;
            MajorLinkerVersion = majorLinkerVersion;
            MinorLinkerVersion = minorLinkerVersion;
            SizeOfCode = sizeOfCode;
            SizeOfInitializedData = sizeOfInitializedData;
            SizeOfUninitializedData = sizeOfUninitializedData;
            AddressOfEntryPoint = addressOfEntryPoint;
            BaseOfCode = baseOfCode;
            BaseOfData = baseOfData;
            ImageBase = imageBase;
            SectionAlignment = sectionAlignment;
            FileAlignment = fileAlignment;
            MajorOperatingSystemVersion = majorOperatingSystemVersion;
            MinorOperatingSystemVersion = minorOperatingSystemVersion;
            MajorImageVersion = majorImageVersion;
            MinorImageVersion = minorImageVersion;
            MajorSubsystemVersion = majorSubsystemVersion;
            MinorSubsystemVersion = minorSubsystemVersion;
            SizeOfImage = sizeOfImage;
            SizeOfHeaders = sizeOfHeaders;
            CheckSum = checkSum;
            Subsystem = subsystem;
            DllCharacteristics = dllCharacteristics;
            SizeOfStackReserve = sizeOfStackReserve;
            SizeOfStackCommit = sizeOfStackCommit;
            SizeOfHeapReserve = sizeOfHeapReserve;
            SizeOfHeapCommit = sizeOfHeapCommit;
            LoaderFlags = loaderFlags;
            NumberOfRvaAndSizes = numberOfRvaAndSizes;
            SectionsNb = sectionsNb;
            SectionsMeanEntropy = sectionsMeanEntropy;
            SectionsMinEntropy = sectionsMinEntropy;
            SectionsMaxEntropy = sectionsMaxEntropy;
            SectionsMeanRawsize = sectionsMeanRawsize;
            SectionsMinRawsize = sectionsMinRawsize;
            SectionMaxRawsize = sectionMaxRawsize;
            SectionsMeanVirtualsize = sectionsMeanVirtualsize;
            SectionsMinVirtualsize = sectionsMinVirtualsize;
            ImportsNbDLL = importsNbDLL;
            ImportsNb = importsNb;
            ImportsNbOrdinal = importsNbOrdinal;
            ExportNb = exportNb;
            ResourcesNb = resourcesNb;
            ResourcesMeanEntropy = resourcesMeanEntropy;
            ResourcesMinEntropy = resourcesMinEntropy;
            ResourcesMaxEntropy = resourcesMaxEntropy;
            ResourcesMeanSize = resourcesMeanSize;
            ResourcesMinSize = resourcesMinSize;
            ResourcesMaxSize = resourcesMaxSize;
            LoadConfigurationSize = loadConfigurationSize;
            VersionInformationSize = versionInformationSize;
        }

        public int Name { get; set; }
        public string Md5 { get; set; }
        public UInt16 Machine { get; set; }
        public UInt16 SizeOfOptionalHeader { get; set; }
        public UInt16 Characteristics { get; set; }
        public Byte MajorLinkerVersion { get; set; }
        public Byte MinorLinkerVersion { get; set; }
        public UInt32 SizeOfCode { get; set; }
        public UInt32 SizeOfInitializedData { get; set; }
        public UInt32 SizeOfUninitializedData { get; set; }
        public UInt32 AddressOfEntryPoint { get; set; }
        public UInt32 BaseOfCode { get; set; }
        public UInt32 BaseOfData { get; set; }
        public UInt64 ImageBase { get; set; }
        public UInt32 SectionAlignment { get; set; }
        public UInt32 FileAlignment { get; set; }
        public UInt16 MajorOperatingSystemVersion { get; set; }
        public UInt16 MinorOperatingSystemVersion { get; set; }
        public UInt16 MajorImageVersion { get; set; }
        public UInt16 MinorImageVersion { get; set; }
        public UInt16 MajorSubsystemVersion { get; set; }
        public UInt16 MinorSubsystemVersion { get; set; }
        public UInt32 SizeOfImage { get; set; }
        public UInt32 SizeOfHeaders { get; set; }
        public UInt32 CheckSum { get; set; }
        public UInt16 Subsystem { get; set; }
        public UInt16 DllCharacteristics { get; set; }
        public UInt64 SizeOfStackReserve { get; set; }
        public UInt64 SizeOfStackCommit { get; set; }
        public UInt64 SizeOfHeapReserve { get; set; }
        public UInt64 SizeOfHeapCommit { get; set; }
        public UInt32 LoaderFlags { get; set; }
        public UInt32 NumberOfRvaAndSizes { get; set; }
        public int SectionsNb { get; set; }
        public double SectionsMeanEntropy { get; set; }
        public double SectionsMinEntropy { get; set; }
        public double SectionsMaxEntropy { get; set; }
        public int SectionsMeanRawsize { get; set; }
        public double SectionsMinRawsize { get; set; }
        public double SectionMaxRawsize { get; set; }
        public int SectionsMeanVirtualsize { get; set; }
        public int SectionsMinVirtualsize { get; set; }
        public int ImportsNbDLL { get; set; }
        public int ImportsNb { get; set; }
        public int ImportsNbOrdinal { get; set; }
        public int ExportNb { get; set; }
        public int ResourcesNb { get; set; }
        public double ResourcesMeanEntropy { get; set; }
        public double ResourcesMinEntropy { get; set; }
        public double ResourcesMaxEntropy { get; set; }
        public double ResourcesMeanSize { get; set; }
        public int ResourcesMinSize { get; set; }
        public int ResourcesMaxSize { get; set; }
        public int LoadConfigurationSize { get; set; }
        public int VersionInformationSize { get; set; }

       
    }
}
