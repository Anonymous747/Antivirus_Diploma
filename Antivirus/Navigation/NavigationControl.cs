using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Antivirus
{
    public class NavigationControl
    {
        List<UserControl> userControlsList = new List<UserControl>();
        Panel panel;

        public NavigationControl(List<UserControl> _userControls, Panel _panel) {
            this.userControlsList = _userControls;
            this.panel = _panel;
            AddUserControls();
        }

        public void AddUserControls()
        {
            for (int i = 0; i < userControlsList.Count; i++)
            {
                userControlsList[i].Dock = DockStyle.Fill;
                panel.Controls.Add(userControlsList[i]);
            }
        }

        public void Display(int index)
        {
            if (index < userControlsList.Count())
            {
                userControlsList[index].BringToFront();
            }
        }
    }
}
