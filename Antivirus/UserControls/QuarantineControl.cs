using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antivirus.UserControls
{
    public partial class QuarantineControl : UserControl
    {
        public QuarantineControl()
        {
            InitializeComponent();
            InitializeQuarantineList();
        }

        private void InitializeQuarantineList()
        {
            var virusedFiles = FileScanningControl.InfectedFiles;

            quarantineBox.Rows.Clear();
            for (var virusedFileIndex = 0; virusedFileIndex < virusedFiles.Count; virusedFileIndex++)  
            {
                quarantineBox[0, virusedFileIndex].Value = virusedFiles[virusedFileIndex];
            }
            
        }

        private void removeAllBtn_Click(object sender, EventArgs e)
        {

        }

        private void cleanListBtn_Click(object sender, EventArgs e)
        {
            quarantineBox.Rows.Clear();
        }

        private void QuarantineControl_Load(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            InitializeQuarantineList();
        }
    }
}
