using Antivirus.Model;
using Antivirus.Repository;
using Antivirus.Source;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using AntivirusML.Model;
using MLModelAntivirus;
using FullAntivirusCheck;

namespace Antivirus.UserControls
{
    public partial class FileScanningControl : UserControl
    {
        private string[] filePaths;
        private static List<InfectedFile> infectedFiles = new List<InfectedFile>();

        public static List<InfectedFile> InfectedFiles { get { return infectedFiles; } }

        public FileScanningControl()
        {
            InitializeComponent();
        }

        private void FileScanningControl_Load(object sender, EventArgs e)
        {

        }

        private void browseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _openFileChoserDialog();
        }

        #region ScanBtn

        private void scanBtn_Click(object sender, EventArgs e)
        {
            var mdSignatures = File.ReadAllLines("MD5Base.txt");
            var signatures = ConvertSignaturesToStringArray();

            lblStatus.Text = "";
            threatsGridView.Rows.Clear();

            progressBar1.Maximum = Constants.kMaximumLoaderValue;
            StartProgressBarCalculations(signatures, 0);

            for (int i = 0, k = 0; i < signatures.Length; i++)
            {
                if (mdSignatures.Contains(signatures[i]))
                {
                    var filePath = filePaths[i];
                    infectedFiles.Add(new InfectedFile(filePath, "Trojan"));
                    threatsGridView.Rows.Add();
                    // Set file path
                    threatsGridView[0, k].Value = filePath;
                    // Set checking time
                    threatsGridView[1, k].Value = DateTime.Now;
                    // Set threat category
                    threatsGridView[2, k].Value = "Trojan";
                    k++;
                    lblStatus.Text = Constants.kInfectedString;
                    lblStatus.ForeColor = Color.Red;
                }
                else if (lblStatus.Text != Constants.kInfectedString)
                {
                    lblStatus.Text = Constants.kCleanString;
                    lblStatus.ForeColor = Color.Green;
                }
                StartProgressBarCalculations(signatures, i + 1);
            }

            if (infectedFiles.Count > 0)
            {
                archivateInfectedFiles();
            }
        }

        void archivateInfectedFiles()
        {
            foreach (var infectedFile in infectedFiles)
            {
                var filePath = infectedFile.Path;
                var fileName = filePath.Split('\\').Last();
                var pathToFileLocation = filePath.Replace(fileName, "");
                var pathToZip = filePath.Replace(".txt", ".zip");
                var temporaryFolder = $"{pathToFileLocation}virusesFolder";

                // Get of rid remained zip files
                if (File.Exists(pathToZip))
                {
                    File.Delete(pathToZip);
                }

                // Directory cleaning
                if (Directory.Exists(temporaryFolder))
                {
                    string[] fileNamesInFolder = Directory.GetFiles(temporaryFolder);
                    foreach (string name in fileNamesInFolder)
                    {
                        File.Delete(name);
                    }
                    Directory.Delete(temporaryFolder);
                }

                Directory.CreateDirectory(temporaryFolder);
                File.Copy(filePath, $"{temporaryFolder}\\{fileName}");
                ZipFile.CreateFromDirectory(temporaryFolder, pathToZip);
            }
        }


        private void StartProgressBarCalculations(string[] signatures, int checkedFiles)
        {
            int length = signatures.Length;

            if (length == checkedFiles)
            {
                progressBar1.Value = Constants.kMaximumLoaderValue;
                MessageBox.Show("The check is complete");
                return;
            }

            progressBar1.Value = Constants.kMaximumLoaderValue / signatures.Length * checkedFiles;
        }

        #endregion

        #region Other

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Selection

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            _openFileChoserDialog();
        }

        private void _openFileChoserDialog()
        {
            listBox1.Items.Clear();
            threatsGridView.Rows.Clear();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePaths = ofd.FileNames;

                foreach (var fileName in filePaths)
                {
                    listBox1.Items.Add(fileName);
                    PeHeaderReader reader = new PeHeaderReader(fileName);
                    var model = reader.ToModel();
                    Console.WriteLine(reader);

                    var input = new ModelInput();
                    model.FillInputModel(ref input);

                    ModelOutput result = ConsumeModel.Predict(input);
                    Console.WriteLine();

                  /*  FullAntivirusCheck.ModelInput sampleData = new FullAntivirusCheck.ModelInput();
                    PeHeaderReader reader = new PeHeaderReader(fileName);
                    var model = reader.ToModel();
                    model.FillFullCheckMLModelInput(ref sampleData);*/

                    /*var predictionResult = FullAntivirusCheck.Predict(sampleData);
                    Console.WriteLine(predictionResult.Legitimate);*/
                    // if (reader.Is32BitHeader)
                    // {
                    //    PeHeaderReader.IMAGE_OPTIONAL_HEADER64 header64 = reader.OptionalHeader64;
                    // }
                    // DateTime timeStamp = reader.TimeStamp;

                }
            }
        }



        private string[] _getTextForPrinting(string[] fileNames)
        {
            if (fileNames.isEmty())
            {
                return new string[1] { "" };
            }

            if (fileNames.Length == 1)
            {
                return new string[1] { GetMD5FromFile(fileNames.Last()) };
            }

            var keys = new List<string>() { GetMD5FromFile(fileNames[0]) };
            for (int i = 1; i < fileNames.Length; i++)
            {
                keys.Add(GetMD5FromFile(fileNames[i]));
            }

            return keys.ToArray();
        }

        public string[] ConvertSignaturesToStringArray()
        {
            int listLength = listBox1.Items.Count;
            var filePaths = new string[listLength];

            for (var i = 0; i < listLength; i++)
            {
                filePaths[i] = listBox1.Items[i].ToString();
            }

            return _getTextForPrinting(filePaths);
        }

        public string GetMD5FromFile(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }
        }

        #endregion
    }
}
