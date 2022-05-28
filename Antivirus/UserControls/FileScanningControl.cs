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
            _OpenFileChoserDialog();
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
                    MLFileChecker fileChecker = new MLFileChecker(filePaths);
                    fileChecker.CheckSelectedFiles();


                    lblStatus.Text = Constants.kCleanString;
                    lblStatus.ForeColor = Color.Green;
                }
                StartProgressBarCalculations(signatures, i + 1);
            }

            if (infectedFiles.Count > 0)
            {
                FileArchivator archivator = new FileArchivator(infectedFiles);
                archivator.ArchivateMalvares();
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
            _OpenFileChoserDialog();
        }

        private void _OpenFileChoserDialog()
        {
            listBox1.Items.Clear();
            threatsGridView.Rows.Clear();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePaths = ofd.FileNames;

                foreach (var filePath in filePaths)
                {
                    listBox1.Items.Add(filePath);
                }
            }
            
            ofd.Dispose();
        }

        public string[] ConvertSignaturesToStringArray()
        {
            int listLength = listBox1.Items.Count;
            var filePaths = new string[listLength];

            for (var i = 0; i < listLength; i++)
            {
                filePaths[i] = listBox1.Items[i].ToString();
            }

            return StringFormatter.GetMd5ForPrinting(filePaths);
        }
        #endregion

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
