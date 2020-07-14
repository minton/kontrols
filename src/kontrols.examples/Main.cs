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
            chkDisableControls.CheckedChanged += (s, e) =>
            {
                RedDot.Enabled =
                    GlobalWar.Enabled =
                        SimpleBorderFormSample.Enabled =
                            RoundedBorderFormSample.Enabled =
                                ZoomMenuSample.Enabled =
                                    diEdge.Enabled =
                                        diExplorer.Enabled =
                                            diPowerShell.Enabled =
                                                PlayPause.Enabled =
                                                    PlayPause.Enabled = chkDisableControls.Checked;
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
            var borderForm = new SimpleBorderForm{BorderColor = GetRandomColor(), ShowTitle = true};
            SetupSampleForm(borderForm);
            borderForm.ShowDialog();
        }

        void RoundedBorderFormSampleClicked(object sender, EventArgs e)
        {
            var roundedForm = new RoundedBorderForm {BackgroundColor = GetRandomColor(), CornerRadius = 25, ShowTitle = true};
            SetupSampleForm(roundedForm);
            roundedForm.ShowDialog();
        }

        void SetupSampleForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterParent;
            form.Size = new Size(480, 300);
            form.Text = $"{form.GetType().Name} Example";
            var btn = new HoverTextButton() {Text = "Close Me", Size = new Size(100, 60), HoverForeColor = Color.Aqua, ForeColor = Color.Black, BackColor = Color.White, HasBorder = true};
            btn.Location = new Point(form.Width / 2 - btn.Width / 2, form.Height / 2 - btn.Height / 2);
            btn.Click += (_, __) => btn.FindForm().Close();
            form.Controls.Add(btn);
        }

        void ExitClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
