using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WpfCustomizableControls.Controls;

namespace WpfCustomizableControls.Groups
{
    public class WpfccButtonGroup
    {
        public WpfccButtonGroup()
        {
            buttons = new List<WpfccButton>();
        }

        public Brush SelectedButtonBackground { get; set; }
        public Brush SelectedButtonIconForeground { get; set; }
        public Brush SelectedButtonForeground { get; set; }

        public Brush UnselectedButtonBackground { get; set; }
        public Brush UnselectedButtonIconForeground { get; set; }
        public Brush UnselectedButtonForeground { get; set; }

        private List<WpfccButton> buttons;
        private WpfccButton lastSelectedButton;

        public List<WpfccButton> Buttons
        {
            get
            {
                return buttons;
            }
            set
            {
                buttons = value;

                if (buttons.Count >= 1)
                {
                    lastSelectedButton = buttons[0];
                }

                for(int i = 0; i < buttons.Count; i++)
                {
                    ApplyStyle(buttons[i], i == 0);
                    buttons[i].Click += WpfccButton_Click;
                }
            }
        }

        public void Add(WpfccButton button)
        {
            buttons.Add(button);
            ApplyStyle(button, false);
        }

        private void WpfccButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if(lastSelectedButton != null)
            {
                ApplyStyle(lastSelectedButton, false);
            }

            WpfccButton selectedButton = (WpfccButton)sender;

            ApplyStyle(selectedButton, true);

            lastSelectedButton = selectedButton;
        }

        private void ApplyStyle(WpfccButton button, bool selected)
        {
            if(selected)
            {
                button.Background = SelectedButtonBackground;
                button.BackgroundHover = SelectedButtonBackground;

                button.IconForeground = SelectedButtonIconForeground;
                button.IconForegroundHover = SelectedButtonIconForeground;

                button.Foreground = SelectedButtonForeground;
                button.ForegroundHover = SelectedButtonForeground;
            }
            else
            {
                button.Background = UnselectedButtonBackground;
                button.BackgroundHover = UnselectedButtonBackground;

                button.IconForeground = UnselectedButtonIconForeground;
                button.IconForegroundHover = UnselectedButtonIconForeground;

                button.Foreground = UnselectedButtonForeground;
                button.ForegroundHover = UnselectedButtonForeground;
            }
        }
    }
}
