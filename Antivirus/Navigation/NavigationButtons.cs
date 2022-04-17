using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Antivirus.Navigation
{
    public class NavigationButtons
    {
        List<Button> buttons;
        Color defaultColor;
        Color selectedColor;

        public NavigationButtons(List<Button> _buttons, Color _defaultColor, Color _selectedColor)
        {
            this.buttons = _buttons;
            this.defaultColor = _defaultColor;
            this.selectedColor = _selectedColor;
            SetDefaultButtonColor();
        }

        private void SetDefaultButtonColor()
        {
            foreach (var button in buttons)
            {
                button.BackColor = defaultColor;
            }
        }

        public void HighlightButton(Button selectedButton)
        {
            foreach (var button in buttons)
            {
                if (button == selectedButton)
                {
                    button.BackColor = selectedColor;
                } else {
                    button.BackColor = defaultColor;
                }
            }
        }
    }
}
