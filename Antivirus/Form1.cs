using Antivirus.Navigation;
using Antivirus.Source;
using Antivirus.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Antivirus
{
    public partial class Form1 : Form
    {

        public const int kHomeScreenIndex = 0;

        NavigationControl navigationControl;
        //NavigationButtons navigationButtons;

        Color btnDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        Color btnSelectedtColor = Color.FromKnownColor(KnownColor.ControlDark);

        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControl();
            //InitializeNavigationButton();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Navigation

       /* private void InitializeNavigationButton()
        {
            List<Button> buttons = new List<Button>() { 
                //scannerBtn, quarantineBtn, systemBtn, updatesBtn, aboutBtn
            };

            //navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedtColor);
            //navigationButtons.HighlightButton(scannerBtn);
        }*/

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new HomeControl(panel2), new FileScanningControl(),
            /*     new QuarantineControl(), new SystemInformationControl(),
            new UpdatesControl(), new AboutApplicationControl()*/
            };

            navigationControl = new NavigationControl(userControls, panel2);
            navigationControl.Display(kHomeScreenIndex);
        }

        #endregion

        /*#region Buttons

        private void quarantineBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(Constants.kQuarantineScreenIndex);
            //navigationButtons.HighlightButton(quarantineBtn);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(Constants.kAboutAppScreenIndex);
            //navigationButtons.HighlightButton(aboutBtn);
        }

        private void updatesBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(Constants.kUpdatesScreenIndex);
            //navigationButtons.HighlightButton(updatesBtn);
        }

        private void systemBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(Constants.kSystemInformationScreenIndex);
            //navigationButtons.HighlightButton(systemBtn);
        }

        private void scannerBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(Constants.kFileScanningScreenIndex);
            //navigationButtons.HighlightButton(scannerBtn);
        }

        #endregion*/

        #region BgrndWorker

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Do not access the form's BackgroundWorker reference directly.
            // Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            // Extract the argument.
            int arg = (int)e.Argument;

            // Start the time-consuming operation.
            e.Result = TimeConsumingOperation(bw, arg);

            // If the operation was canceled by the user,
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // The user canceled the operation.
                MessageBox.Show("Operation was canceled");
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else
            {
                // The operation completed normally.
                string msg = String.Format("Result = {0}", e.Result);
                MessageBox.Show(msg);
            }
        }

        private int TimeConsumingOperation(
            BackgroundWorker bw,
            int sleepPeriod)
        {
            int result = 0;

            Random rand = new Random();

            while (!bw.CancellationPending)
            {
                bool exit = false;

                switch (rand.Next(3))
                {
                    // Raise an exception.
                    case 0:
                        {
                            throw new Exception("An error condition occurred.");
                        }

                    // Sleep for the number of milliseconds
                    // specified by the sleepPeriod parameter.
                    case 1:
                        {
                            Thread.Sleep(sleepPeriod);
                            break;
                        }

                    // Exit and return normally.
                    case 2:
                        {
                            result = 23;
                            exit = true;
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }

                if (exit)
                {
                    break;
                }
            }

            return result;
        }

        /*
         
        private void startBtn_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.RunWorkerAsync(2000);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.backgroundWorker1.CancelAsync();
        }

        */

        #endregion


        /*private void button4_Click(object sender, EventArgs e)
        {
            navigationControl.Display(Constants.kFileScanningScreenIndex);
            //navigationButtons.HighlightButton(scannerBtn);
        }*/
    }
}
