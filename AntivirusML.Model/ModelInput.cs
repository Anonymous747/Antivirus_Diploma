// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace AntivirusML.Model
{
    public class ModelInput
    {
        [ColumnName("Name"), LoadColumn(0)]
        public string Name { get; set; }


        [ColumnName("md5"), LoadColumn(1)]
        public string Md5 { get; set; }


        [ColumnName("Machine"), LoadColumn(2)]
        public float Machine { get; set; }


        [ColumnName("SizeOfOptionalHeader"), LoadColumn(3)]
        public float SizeOfOptionalHeader { get; set; }


        [ColumnName("Characteristics"), LoadColumn(4)]
        public float Characteristics { get; set; }


        [ColumnName("MajorLinkerVersion"), LoadColumn(5)]
        public float MajorLinkerVersion { get; set; }


        [ColumnName("MinorLinkerVersion"), LoadColumn(6)]
        public float MinorLinkerVersion { get; set; }


        [ColumnName("SizeOfCode"), LoadColumn(7)]
        public float SizeOfCode { get; set; }


        [ColumnName("SizeOfInitializedData"), LoadColumn(8)]
        public float SizeOfInitializedData { get; set; }


        [ColumnName("SizeOfUninitializedData"), LoadColumn(9)]
        public float SizeOfUninitializedData { get; set; }


        [ColumnName("AddressOfEntryPoint"), LoadColumn(10)]
        public float AddressOfEntryPoint { get; set; }


        [ColumnName("BaseOfCode"), LoadColumn(11)]
        public float BaseOfCode { get; set; }


        [ColumnName("BaseOfData"), LoadColumn(12)]
        public float BaseOfData { get; set; }


        [ColumnName("ImageBase"), LoadColumn(13)]
        public float ImageBase { get; set; }


        [ColumnName("SectionAlignment"), LoadColumn(14)]
        public float SectionAlignment { get; set; }


        [ColumnName("FileAlignment"), LoadColumn(15)]
        public float FileAlignment { get; set; }


        [ColumnName("MajorOperatingSystemVersion"), LoadColumn(16)]
        public float MajorOperatingSystemVersion { get; set; }


        [ColumnName("MinorOperatingSystemVersion"), LoadColumn(17)]
        public float MinorOperatingSystemVersion { get; set; }


        [ColumnName("MajorImageVersion"), LoadColumn(18)]
        public float MajorImageVersion { get; set; }


        [ColumnName("MinorImageVersion"), LoadColumn(19)]
        public float MinorImageVersion { get; set; }


        [ColumnName("MajorSubsystemVersion"), LoadColumn(20)]
        public float MajorSubsystemVersion { get; set; }


        [ColumnName("MinorSubsystemVersion"), LoadColumn(21)]
        public float MinorSubsystemVersion { get; set; }


        [ColumnName("SizeOfImage"), LoadColumn(22)]
        public float SizeOfImage { get; set; }


        [ColumnName("SizeOfHeaders"), LoadColumn(23)]
        public float SizeOfHeaders { get; set; }


        [ColumnName("CheckSum"), LoadColumn(24)]
        public float CheckSum { get; set; }


        [ColumnName("Subsystem"), LoadColumn(25)]
        public float Subsystem { get; set; }


        [ColumnName("DllCharacteristics"), LoadColumn(26)]
        public float DllCharacteristics { get; set; }


        [ColumnName("SizeOfStackReserve"), LoadColumn(27)]
        public float SizeOfStackReserve { get; set; }


        [ColumnName("SizeOfStackCommit"), LoadColumn(28)]
        public float SizeOfStackCommit { get; set; }


        [ColumnName("SizeOfHeapReserve"), LoadColumn(29)]
        public float SizeOfHeapReserve { get; set; }


        [ColumnName("SizeOfHeapCommit"), LoadColumn(30)]
        public float SizeOfHeapCommit { get; set; }


        [ColumnName("LoaderFlags"), LoadColumn(31)]
        public float LoaderFlags { get; set; }


        [ColumnName("NumberOfRvaAndSizes"), LoadColumn(32)]
        public float NumberOfRvaAndSizes { get; set; }


        [ColumnName("SectionsNb"), LoadColumn(33)]
        public float SectionsNb { get; set; }


        [ColumnName("SectionsMeanEntropy"), LoadColumn(34)]
        public float SectionsMeanEntropy { get; set; }


        [ColumnName("SectionsMinEntropy"), LoadColumn(35)]
        public float SectionsMinEntropy { get; set; }


        [ColumnName("SectionsMaxEntropy"), LoadColumn(36)]
        public float SectionsMaxEntropy { get; set; }


        [ColumnName("SectionsMeanRawsize"), LoadColumn(37)]
        public float SectionsMeanRawsize { get; set; }


        [ColumnName("SectionsMinRawsize"), LoadColumn(38)]
        public float SectionsMinRawsize { get; set; }


        [ColumnName("SectionMaxRawsize"), LoadColumn(39)]
        public float SectionMaxRawsize { get; set; }


        [ColumnName("SectionsMeanVirtualsize"), LoadColumn(40)]
        public float SectionsMeanVirtualsize { get; set; }


        [ColumnName("SectionsMinVirtualsize"), LoadColumn(41)]
        public float SectionsMinVirtualsize { get; set; }


        [ColumnName("SectionMaxVirtualsize"), LoadColumn(42)]
        public float SectionMaxVirtualsize { get; set; }


        [ColumnName("ImportsNbDLL"), LoadColumn(43)]
        public float ImportsNbDLL { get; set; }


        [ColumnName("ImportsNb"), LoadColumn(44)]
        public float ImportsNb { get; set; }


        [ColumnName("ImportsNbOrdinal"), LoadColumn(45)]
        public float ImportsNbOrdinal { get; set; }


        [ColumnName("ExportNb"), LoadColumn(46)]
        public float ExportNb { get; set; }


        [ColumnName("ResourcesNb"), LoadColumn(47)]
        public float ResourcesNb { get; set; }


        [ColumnName("ResourcesMeanEntropy"), LoadColumn(48)]
        public float ResourcesMeanEntropy { get; set; }


        [ColumnName("ResourcesMinEntropy"), LoadColumn(49)]
        public float ResourcesMinEntropy { get; set; }


        [ColumnName("ResourcesMaxEntropy"), LoadColumn(50)]
        public float ResourcesMaxEntropy { get; set; }


        [ColumnName("ResourcesMeanSize"), LoadColumn(51)]
        public float ResourcesMeanSize { get; set; }


        [ColumnName("ResourcesMinSize"), LoadColumn(52)]
        public float ResourcesMinSize { get; set; }


        [ColumnName("ResourcesMaxSize"), LoadColumn(53)]
        public float ResourcesMaxSize { get; set; }


        [ColumnName("LoadConfigurationSize"), LoadColumn(54)]
        public float LoadConfigurationSize { get; set; }


        [ColumnName("VersionInformationSize"), LoadColumn(55)]
        public float VersionInformationSize { get; set; }


        [ColumnName("legitimate"), LoadColumn(56)]
        public string Legitimate { get; set; }

    }
}