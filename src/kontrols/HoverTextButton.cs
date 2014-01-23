using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace kontrols
{
    public partial class HoverTextButton : UserControl
    {
        Color _foreColor;
        Color _hoverForeColor;
        bool _mouseIsOverControl;

        public HoverTextButton()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint , true);
            UpdateStyles();
            Paint += Render;
            MouseHover += (s, e) => { _mouseIsOverControl = true; };
            MouseLeave += (s, e) => { _mouseIsOverControl = false; };
        }

        /// <summary>
        /// The color used when the mouse is not over the control.
        /// </summary>
        public override Color ForeColor
        {
            get
            {
                return _foreColor;
            }
            set {
                _foreColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The color used when the mouse is over the control.
        /// </summary>
        public Color HoverForeColor
        {
            get
            {
                return _hoverForeColor;
            }
            set
            {
                _hoverForeColor = value;
                Invalidate();
            }
        }

        void Render(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            //graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            graphics.Clear(BackColor);
            if (string.IsNullOrWhiteSpace(Text)) return;
            TextRenderer.DrawText(graphics, Text, Font, new Point(0, 0), _mouseIsOverControl ? _hoverForeColor : _foreColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
