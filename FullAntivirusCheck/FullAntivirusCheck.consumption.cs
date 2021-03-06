// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace FullAntivirusCheck
{
    public partial class FullAntivirusCheck
    {
        /// <summary>
        /// model input class for FullAntivirusCheck.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"Name")]
            public string Name { get; set; }

            [ColumnName(@"md5")]
            public string Md5 { get; set; }

            [ColumnName(@"Machine")]
            public float Machine { get; set; }

            [ColumnName(@"SizeOfOptionalHeader")]
            public float SizeOfOptionalHeader { get; set; }

            [ColumnName(@"Characteristics")]
            public float Characteristics { get; set; }

            [ColumnName(@"MajorLinkerVersion")]
            public float MajorLinkerVersion { get; set; }

            [ColumnName(@"MinorLinkerVersion")]
            public float MinorLinkerVersion { get; set; }

            [ColumnName(@"SizeOfCode")]
            public float SizeOfCode { get; set; }

            [ColumnName(@"SizeOfInitializedData")]
            public float SizeOfInitializedData { get; set; }

            [ColumnName(@"SizeOfUninitializedData")]
            public float SizeOfUninitializedData { get; set; }

            [ColumnName(@"AddressOfEntryPoint")]
            public float AddressOfEntryPoint { get; set; }

            [ColumnName(@"BaseOfCode")]
            public float BaseOfCode { get; set; }

            [ColumnName(@"BaseOfData")]
            public float BaseOfData { get; set; }

            [ColumnName(@"ImageBase")]
            public float ImageBase { get; set; }

            [ColumnName(@"SectionAlignment")]
            public float SectionAlignment { get; set; }

            [ColumnName(@"FileAlignment")]
            public float FileAlignment { get; set; }

            [ColumnName(@"MajorOperatingSystemVersion")]
            public float MajorOperatingSystemVersion { get; set; }

            [ColumnName(@"MinorOperatingSystemVersion")]
            public float MinorOperatingSystemVersion { get; set; }

            [ColumnName(@"MajorImageVersion")]
            public float MajorImageVersion { get; set; }

            [ColumnName(@"MinorImageVersion")]
            public float MinorImageVersion { get; set; }

            [ColumnName(@"MajorSubsystemVersion")]
            public float MajorSubsystemVersion { get; set; }

            [ColumnName(@"MinorSubsystemVersion")]
            public float MinorSubsystemVersion { get; set; }

            [ColumnName(@"SizeOfImage")]
            public float SizeOfImage { get; set; }

            [ColumnName(@"SizeOfHeaders")]
            public float SizeOfHeaders { get; set; }

            [ColumnName(@"CheckSum")]
            public float CheckSum { get; set; }

            [ColumnName(@"Subsystem")]
            public float Subsystem { get; set; }

            [ColumnName(@"DllCharacteristics")]
            public float DllCharacteristics { get; set; }

            [ColumnName(@"SizeOfStackReserve")]
            public float SizeOfStackReserve { get; set; }

            [ColumnName(@"SizeOfStackCommit")]
            public float SizeOfStackCommit { get; set; }

            [ColumnName(@"SizeOfHeapReserve")]
            public float SizeOfHeapReserve { get; set; }

            [ColumnName(@"SizeOfHeapCommit")]
            public float SizeOfHeapCommit { get; set; }

            [ColumnName(@"LoaderFlags")]
            public float LoaderFlags { get; set; }

            [ColumnName(@"NumberOfRvaAndSizes")]
            public float NumberOfRvaAndSizes { get; set; }

            [ColumnName(@"SectionsNb")]
            public float SectionsNb { get; set; }

            [ColumnName(@"SectionsMeanEntropy")]
            public float SectionsMeanEntropy { get; set; }

            [ColumnName(@"SectionsMinEntropy")]
            public float SectionsMinEntropy { get; set; }

            [ColumnName(@"SectionsMaxEntropy")]
            public float SectionsMaxEntropy { get; set; }

            [ColumnName(@"SectionsMeanRawsize")]
            public float SectionsMeanRawsize { get; set; }

            [ColumnName(@"SectionsMinRawsize")]
            public float SectionsMinRawsize { get; set; }

            [ColumnName(@"SectionMaxRawsize")]
            public float SectionMaxRawsize { get; set; }

            [ColumnName(@"SectionsMeanVirtualsize")]
            public float SectionsMeanVirtualsize { get; set; }

            [ColumnName(@"SectionsMinVirtualsize")]
            public float SectionsMinVirtualsize { get; set; }

            [ColumnName(@"SectionMaxVirtualsize")]
            public float SectionMaxVirtualsize { get; set; }

            [ColumnName(@"ImportsNbDLL")]
            public float ImportsNbDLL { get; set; }

            [ColumnName(@"ImportsNb")]
            public float ImportsNb { get; set; }

            [ColumnName(@"ImportsNbOrdinal")]
            public float ImportsNbOrdinal { get; set; }

            [ColumnName(@"ExportNb")]
            public float ExportNb { get; set; }

            [ColumnName(@"ResourcesNb")]
            public float ResourcesNb { get; set; }

            [ColumnName(@"ResourcesMeanEntropy")]
            public float ResourcesMeanEntropy { get; set; }

            [ColumnName(@"ResourcesMinEntropy")]
            public float ResourcesMinEntropy { get; set; }

            [ColumnName(@"ResourcesMaxEntropy")]
            public float ResourcesMaxEntropy { get; set; }

            [ColumnName(@"ResourcesMeanSize")]
            public float ResourcesMeanSize { get; set; }

            [ColumnName(@"ResourcesMinSize")]
            public float ResourcesMinSize { get; set; }

            [ColumnName(@"ResourcesMaxSize")]
            public float ResourcesMaxSize { get; set; }

            [ColumnName(@"LoadConfigurationSize")]
            public float LoadConfigurationSize { get; set; }

            [ColumnName(@"VersionInformationSize")]
            public float VersionInformationSize { get; set; }

            [ColumnName(@"legitimate")]
            public bool Legitimate { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for FullAntivirusCheck.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"Name")]
            public float[] Name { get; set; }

            [ColumnName(@"md5")]
            public float[] Md5 { get; set; }

            [ColumnName(@"Machine")]
            public float Machine { get; set; }

            [ColumnName(@"SizeOfOptionalHeader")]
            public float SizeOfOptionalHeader { get; set; }

            [ColumnName(@"Characteristics")]
            public float Characteristics { get; set; }

            [ColumnName(@"MajorLinkerVersion")]
            public float MajorLinkerVersion { get; set; }

            [ColumnName(@"MinorLinkerVersion")]
            public float MinorLinkerVersion { get; set; }

            [ColumnName(@"SizeOfCode")]
            public float SizeOfCode { get; set; }

            [ColumnName(@"SizeOfInitializedData")]
            public float SizeOfInitializedData { get; set; }

            [ColumnName(@"SizeOfUninitializedData")]
            public float SizeOfUninitializedData { get; set; }

            [ColumnName(@"AddressOfEntryPoint")]
            public float AddressOfEntryPoint { get; set; }

            [ColumnName(@"BaseOfCode")]
            public float BaseOfCode { get; set; }

            [ColumnName(@"BaseOfData")]
            public float BaseOfData { get; set; }

            [ColumnName(@"ImageBase")]
            public float ImageBase { get; set; }

            [ColumnName(@"SectionAlignment")]
            public float SectionAlignment { get; set; }

            [ColumnName(@"FileAlignment")]
            public float FileAlignment { get; set; }

            [ColumnName(@"MajorOperatingSystemVersion")]
            public float MajorOperatingSystemVersion { get; set; }

            [ColumnName(@"MinorOperatingSystemVersion")]
            public float MinorOperatingSystemVersion { get; set; }

            [ColumnName(@"MajorImageVersion")]
            public float MajorImageVersion { get; set; }

            [ColumnName(@"MinorImageVersion")]
            public float MinorImageVersion { get; set; }

            [ColumnName(@"MajorSubsystemVersion")]
            public float MajorSubsystemVersion { get; set; }

            [ColumnName(@"MinorSubsystemVersion")]
            public float MinorSubsystemVersion { get; set; }

            [ColumnName(@"SizeOfImage")]
            public float SizeOfImage { get; set; }

            [ColumnName(@"SizeOfHeaders")]
            public float SizeOfHeaders { get; set; }

            [ColumnName(@"CheckSum")]
            public float CheckSum { get; set; }

            [ColumnName(@"Subsystem")]
            public float Subsystem { get; set; }

            [ColumnName(@"DllCharacteristics")]
            public float DllCharacteristics { get; set; }

            [ColumnName(@"SizeOfStackReserve")]
            public float SizeOfStackReserve { get; set; }

            [ColumnName(@"SizeOfStackCommit")]
            public float SizeOfStackCommit { get; set; }

            [ColumnName(@"SizeOfHeapReserve")]
            public float SizeOfHeapReserve { get; set; }

            [ColumnName(@"SizeOfHeapCommit")]
            public float SizeOfHeapCommit { get; set; }

            [ColumnName(@"LoaderFlags")]
            public float LoaderFlags { get; set; }

            [ColumnName(@"NumberOfRvaAndSizes")]
            public float NumberOfRvaAndSizes { get; set; }

            [ColumnName(@"SectionsNb")]
            public float SectionsNb { get; set; }

            [ColumnName(@"SectionsMeanEntropy")]
            public float SectionsMeanEntropy { get; set; }

            [ColumnName(@"SectionsMinEntropy")]
            public float SectionsMinEntropy { get; set; }

            [ColumnName(@"SectionsMaxEntropy")]
            public float SectionsMaxEntropy { get; set; }

            [ColumnName(@"SectionsMeanRawsize")]
            public float SectionsMeanRawsize { get; set; }

            [ColumnName(@"SectionsMinRawsize")]
            public float SectionsMinRawsize { get; set; }

            [ColumnName(@"SectionMaxRawsize")]
            public float SectionMaxRawsize { get; set; }

            [ColumnName(@"SectionsMeanVirtualsize")]
            public float SectionsMeanVirtualsize { get; set; }

            [ColumnName(@"SectionsMinVirtualsize")]
            public float SectionsMinVirtualsize { get; set; }

            [ColumnName(@"SectionMaxVirtualsize")]
            public float SectionMaxVirtualsize { get; set; }

            [ColumnName(@"ImportsNbDLL")]
            public float ImportsNbDLL { get; set; }

            [ColumnName(@"ImportsNb")]
            public float ImportsNb { get; set; }

            [ColumnName(@"ImportsNbOrdinal")]
            public float ImportsNbOrdinal { get; set; }

            [ColumnName(@"ExportNb")]
            public float ExportNb { get; set; }

            [ColumnName(@"ResourcesNb")]
            public float ResourcesNb { get; set; }

            [ColumnName(@"ResourcesMeanEntropy")]
            public float ResourcesMeanEntropy { get; set; }

            [ColumnName(@"ResourcesMinEntropy")]
            public float ResourcesMinEntropy { get; set; }

            [ColumnName(@"ResourcesMaxEntropy")]
            public float ResourcesMaxEntropy { get; set; }

            [ColumnName(@"ResourcesMeanSize")]
            public float ResourcesMeanSize { get; set; }

            [ColumnName(@"ResourcesMinSize")]
            public float ResourcesMinSize { get; set; }

            [ColumnName(@"ResourcesMaxSize")]
            public float ResourcesMaxSize { get; set; }

            [ColumnName(@"LoadConfigurationSize")]
            public float LoadConfigurationSize { get; set; }

            [ColumnName(@"VersionInformationSize")]
            public float VersionInformationSize { get; set; }

            [ColumnName(@"legitimate")]
            public bool Legitimate { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"PredictedLabel")]
            public bool PredictedLabel { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

            [ColumnName(@"Probability")]
            public float Probability { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("FullAntivirusCheck.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
