using Antivirus.Navigation;
using Antivirus.Source;
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
    public partial class HomeControl : UserControl
    {
        private Panel _panel;

        public HomeControl(Panel panel)
        {
            _panel = panel;
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
        }

        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btnDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        Color btnSelectedtColor = Color.FromKnownColor(KnownColor.ControlDark);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Navigation

        private void InitializeNavigationButton()
        {
            List<Button> buttons = new List<Button>()
            {
                ScanBtn, QuarantineBtn,//scannerBtn, quarantineBtn, systemBtn, updatesBtn, aboutBtn
            };

            //navigationButtons = new NavigationButtons(buttons, btnDefaultColor, btnSelectedtColor);
            //navigationButtons.HighlightButton(scannerBtn);
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new FileScanningControl(), new QuarantineControl(), new SystemInformationControl(),
            new UpdatesControl(), new AboutApplicationControl() };


            navigationControl = new NavigationControl(userControls, _panel);
            navigationControl.Display(NavigationConstants.kFileScanningScreenIndex);
        }

        #endregion

        #region Buttons

        private void quarantineBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(NavigationConstants.kQuarantineScreenIndex);
            //navigationButtons.HighlightButton(quarantineBtn);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(NavigationConstants.kAboutAppScreenIndex);
            //navigationButtons.HighlightButton(aboutBtn);
        }

        private void updatesBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(NavigationConstants.kUpdatesScreenIndex);
            //navigationButtons.HighlightButton(updatesBtn);
        }

        private void systemBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(NavigationConstants.kSystemInformationScreenIndex);
            //navigationButtons.HighlightButton(systemBtn);
        }

        private void scannerBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(NavigationConstants.kFileScanningScreenIndex);
            //navigationButtons.HighlightButton(scannerBtn);
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(NavigationConstants.kFileScanningScreenIndex);
            //navigationButtons.HighlightButton(scannerBtn);
        }
        #endregion

        private void QuarantineBtn_Click_1(object sender, EventArgs e)
        {
            navigationControl.Display(NavigationConstants.kQuarantineScreenIndex);
        }
    }

    static class NavigationConstants {
        public const int kHomeScreenIndex = 9;
        public const int kFileScanningScreenIndex = 0;
        public const int kQuarantineScreenIndex = 1;
        public const int kSystemInformationScreenIndex = 2;
        public const int kUpdatesScreenIndex = 3;
        public const int kAboutAppScreenIndex = 4;
    }
}
