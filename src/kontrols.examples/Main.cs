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

    }
}
