using Antivirus.Model;
using Antivirus.Navigation;
using Antivirus.Repository;
using Antivirus.Source;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Antivirus.UserControls
{
    public partial class FileScanningControl : UserControl
    {
        private Panel _panel;
        private string[] filePaths;
        private static List<InfectedFile> infectedFiles = new List<InfectedFile>();

        public static List<InfectedFile> InfectedFiles { get { return infectedFiles; } }

        public FileScanningControl(Panel panel)
        {
            _panel = panel;
            InitializeComponent();
            InitializeNavigationControl();
        }

        NavigationControl navigationControl;

        #region Navigation

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new QuarantineControl(), };


            navigationControl = new NavigationControl(userControls, _panel);
            //navigationControl.Display(FileScanningNavigationConstants.kQuarantineScreenIndex);
        }

        #endregion

        private void browseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _OpenFileChoserDialog();
        }

        #region ScanBtn
        private void scanBtn_Click(object sender, EventArgs e)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();
            timer.Start();

            var mdSignatures = File.ReadAllLines("MD5Base.txt");
            var signatures = ConvertSignaturesToStringArray();

            ScanResultLabel.Text = "";
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

                    ScanResultLabel.Text = Constants.kInfectedString;
                    ScanResultLabel.ForeColor = ColorPalette.Red;
                }
                else if (ScanResultLabel.Text != Constants.kInfectedString)
                {
                    MLFileChecker fileChecker = new MLFileChecker(filePaths);
                    fileChecker.CheckSelectedFiles();


                    ScanResultLabel.Text = Constants.kCleanString;
                    ScanResultLabel.ForeColor = ColorPalette.Green;
                }
                StartProgressBarCalculations(signatures, i + 1);

                if (ItemScannedNumber.Text != "")
                {
                    ItemScannedNumber.Text = (int.Parse(ItemScannedNumber.Text) + 1).ToString();
                }

                if (infectedFiles.Count > 0)
            {
                FileArchivator archivator = new FileArchivator(infectedFiles);
                archivator.ArchivateMalvares();
            }

            timer.Stop();
            TimeSpan timeSpan = TimeSpan.FromMilliseconds(timer.ElapsedMilliseconds);
                string time = string.Format("{0:D2}:{1:D2}:{2:D2}:", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
                TimeTakenNumber.Text = time;
            }
            timer.Reset();
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


        private void homePageBtn_Click(object sender, EventArgs e)
        {
            navigationControl = new NavigationControl(new List<UserControl>()
            {
                new FileScanningControl(_panel)

            }
                , _panel);
            navigationControl.Display(FileScanningNavigationConstants.kHomeScreenIndex
                );
        }

        private void QuarantineBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(FileScanningNavigationConstants.kQuarantineScreenIndex);
        }
    }

    static class FileScanningNavigationConstants
    {
        public const int kHomeScreenIndex = 0;
        public const int kQuarantineScreenIndex = 0;
    }
}
