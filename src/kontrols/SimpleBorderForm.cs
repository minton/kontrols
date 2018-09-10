using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace kontrols
{
    public partial class SimpleBorderForm : Form
    {
        protected string Version;
        Color _borderColor;

        public SimpleBorderForm()
        {
            InitializeComponent();
            MouseDown += HandleMouseMove;
        }

        #region mouse movement

        protected void AddDraggableControl(params Control[] draggableControls)
        {
            foreach (var control in draggableControls)
            {
                control.MouseDown += HandleMouseMove;
            }
        }

        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        void HandleMouseMove(object s, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        #endregion

        #region painting

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            using (var p = new Pen(_borderColor.IsEmpty ? Color.Orange : _borderColor, 2))
            {
                e.Graphics.DrawRectangle(p, 2, 2, Width-4, Height -4);
            }
        }

        #endregion
    }
}
