using System.Windows.Forms;
using kontrols.examples.Properties;

namespace kontrols.examples
{
    public partial class ZoomMenuExampleForm : Form
    {
        public ZoomMenuExampleForm()
        {
            InitializeComponent();
            BuildItems();
        }

        void BuildItems()
        {
            zoomMenu1.Add(Resources.compass, "Safari");
            zoomMenu1.Add(Resources.iBooksAppIcon, "Books");
            zoomMenu1.Add(Resources.iMovie, "iMovie");
            zoomMenu1.Add(Resources.iTunes, "iTunes");
            zoomMenu1.Add(Resources.maps, "Maps");
            zoomMenu1.Add(Resources.Numbers, "Numbers");
            zoomMenu1.Add(Resources.Code, "VS Code");
            zoomMenu1.Add(Resources.Xcode, "Xcode");
            zoomMenu1.Add(Resources.Hyper, "Hyper");
            zoomMenu1.Add(Resources.Telegram, "Telegram");
            zoomMenu1.Add(Resources.PrefApp, "System Preferences");
        }
    }
}
