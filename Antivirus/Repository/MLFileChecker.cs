using System;

namespace Antivirus.Repository
{
    public class MLFileChecker
    {
        private String[] filePaths;

        public MLFileChecker(String[] paths)
        {
            this.filePaths = paths;
        }

        public void CheckSelectedFiles()
        {
            foreach (var filePath in filePaths)
            {
                /*var reader = new PeHeaderReader(filePath);
                        var model = reader.ToModel(filePath);

                        var input = new ModelInput();
                        model.FillInputModel(ref input);

                        ModelOutput result = ConsumeModel.Predict(input);
                        Console.WriteLine();*/

                EquatableMlModel.ModelInput sampleData = new EquatableMlModel.ModelInput();
                PeHeaderReader reader = new PeHeaderReader(filePath);
                if (reader.IsFileExecutable)
                {
                    var model = reader.ToModel(filePath);
                    model.FillEquatableMLModelInput(ref sampleData);

                    var predictionResult = EquatableMlModel.Predict(sampleData);
                    Console.WriteLine(predictionResult.PredictedLabel);
                    Console.WriteLine(predictionResult.Probability);
                    Console.WriteLine(predictionResult.Legitimate);
                }
            }
        }
    }
}
