using System;
using System.Drawing;
using System.Windows.Forms;

namespace kontrols.examples
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            chkButtonsEnabled.CheckedChanged += (s, e) =>
            {
                RedDot.Enabled =
                    GlobalWar.Enabled =
                        PlayPause.Enabled = !PlayPause.Enabled;
            };
        }        

        void ButtonClicked(object sender, System.EventArgs e)
        {
            MessageBox.Show(string.Format("You clicked the {0}.", sender.GetType().Name));
        }

        void ToggleClicked(object sender, System.EventArgs e)
        {
            MessageBox.Show(string.Format("You clicked the {0}. \r\nCurrent state: {1}.", sender.GetType().Name, PlayPause.Toggled));
        }

        private void ViewSimpleBorderFormExampleClicked(object sender, System.EventArgs e)
        {
            var borderForm = new SampleSimpleBorderForm{BorderColor = GetRandomColor()};
            borderForm.Show();
        }

        private Color GetRandomColor()
        {
            var colors = new[] {Color.Aqua, Color.Orange, Color.Plum, Color.DarkOrchid, Color.LightBlue, Color.Yellow};
            return colors[new Random().Next(colors.Length)];
        }
    }
}
