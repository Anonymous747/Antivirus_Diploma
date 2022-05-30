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
        }

        NavigationControl navigationControl;

        Color btnDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        Color btnSelectedtColor = Color.FromKnownColor(KnownColor.ControlDark);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Navigation

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new FileScanningControl(_panel), new QuarantineControl(), new SystemInformationControl(),
            new UpdatesControl(), new AboutApplicationControl() };


            navigationControl = new NavigationControl(userControls, _panel);
            navigationControl.Display(NavigationConstants.kFileScanningScreenIndex);
        }

        #endregion

        #region Buttons

        private void QuarantineBtn_Click_1(object sender, EventArgs e)
        {
            navigationControl.Display(NavigationConstants.kQuarantineScreenIndex);
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(NavigationConstants.kAboutAppScreenIndex);
        }

        private void UpdatesBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(NavigationConstants.kUpdatesScreenIndex);
        }

        private void SystemBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(NavigationConstants.kSystemInformationScreenIndex);
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(NavigationConstants.kFileScanningScreenIndex);
        }
        #endregion

      
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
