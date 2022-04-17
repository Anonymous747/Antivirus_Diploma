using AntivirusML.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antivirus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add input data
            var input = new ModelInput();

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
