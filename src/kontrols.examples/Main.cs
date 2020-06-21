using System;
using System.Drawing;
using System.Windows.Forms;

namespace kontrols.examples
{
    public partial class Main : SimpleBorderForm
    {
        public Main()
        {
            InitializeComponent();
            BorderColor = GetRandomColor();
            chkButtonsEnabled.CheckedChanged += (s, e) =>
            {
                RedDot.Enabled =
                    GlobalWar.Enabled =
                        SimpleBorderFormSample.Enabled =
                            ZoomMenuSample.Enabled =
                                diEdge.Enabled =
                                    diExplorer.Enabled =
                                        diPowerShell.Enabled =
                                            PlayPause.Enabled = 
                                                PlayPause.Enabled = chkButtonsEnabled.Checked;
            };
        }        

        void ButtonClicked(object sender, EventArgs e)
        {
            var text = ((Control) sender).Text;
            var what = string.IsNullOrEmpty(text) ? "Me" : text;
            MessageBox.Show($"You clicked the {what}.");
        }

        void ToggleClicked(object sender, EventArgs e)
        {
            MessageBox.Show($"You clicked the {sender.GetType().Name}. \r\nCurrent state: {PlayPause.Toggled}.");
        }

        Color GetRandomColor()
        {
            var colors = new[] {Color.Aqua, Color.Orange, Color.Plum, Color.DarkOrchid, Color.LightBlue, Color.Yellow};
            return colors[new Random().Next(colors.Length)];
        }

        void ZoomMenuSampleClicked(object sender, EventArgs e)
        {
            var zoom = new ZoomMenuExampleForm();
            zoom.ShowDialog();
        }

        void SimpleBorderFormSampleClicked(object sender, EventArgs e)
        {
            var borderForm = new SampleSimpleBorderForm{BorderColor = GetRandomColor()};
            borderForm.ShowDialog();
        }

        void RoundedBorderFormSampleClicked(object sender, EventArgs e)
        {
            var roundedForm = new SampleRoundedBorderForm {BackgroundColor = GetRandomColor()};
            roundedForm.ShowDialog();
        }

        void ExitClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
