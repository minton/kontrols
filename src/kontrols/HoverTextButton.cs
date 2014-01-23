using System.ComponentModel;
using System.Drawing;
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
            MouseEnter += (s, e) => { MouseIsOverControl = true; };
            MouseLeave += (s, e) => { MouseIsOverControl = false; };
        }

        /// <summary>
        /// The color used when the mouse is not over the control.
        /// </summary>
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; Invalidate(); }
        }

        bool MouseIsOverControl
        {
            set
            {
                _mouseIsOverControl = value;
                Invalidate();
            }
        }

        void Render(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.Clear(BackColor);
            if (string.IsNullOrWhiteSpace(Text)) return;
            TextRenderer.DrawText(graphics, 
                                  Text, 
                                  Font, 
                                  ClientRectangle, 
                                  _mouseIsOverControl ? _hoverForeColor : _foreColor, 
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
