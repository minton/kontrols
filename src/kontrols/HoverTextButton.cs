using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace kontrols
{
    [DefaultEvent("Click")]
    public partial class HoverTextButton : UserControl
    {
        bool _hasBorder;
        Color _foreColor;
        Color _hoverForeColor;
        bool _mouseIsOverControl;
        bool _grayScaleWhenDisabled;

        public HoverTextButton()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint , true);
            UpdateStyles();
            Paint += Render;
            MouseEnter += (s, e) => { MouseIsOverControl = true; };
            MouseLeave += (s, e) => { MouseIsOverControl = false; };
            EnabledChanged += (s, e) => Invalidate();
        }

        /// <summary>
        /// Determines if the text is renders as gray scale if the button is disabled.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        public bool GrayScaleWhenDisabled
        {
            get { return _grayScaleWhenDisabled; }
            set { _grayScaleWhenDisabled = value; Invalidate(); }
        }

        /// <summary>
        /// The color used when the mouse is not over the control.
        /// </summary>
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(false)]
        public bool HasBorder
        {
            get
            {
                return _hasBorder;
            }
            set {
                _hasBorder = value;
                if (_hasBorder) BorderStyle = BorderStyle.None;
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
            var foreColor = !Enabled && _grayScaleWhenDisabled
                ? Color.DarkGray
                : ForeColor;
            var color = _mouseIsOverControl ? _hoverForeColor : foreColor;
            TextRenderer.DrawText(graphics, 
                                  Text, 
                                  Font, 
                                  new Rectangle(0, 0, ClientRectangle.Width -4 , ClientRectangle.Height - 4), 
                                  color, 
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak | TextFormatFlags.EndEllipsis);

            if (_hasBorder)
            {
                using (var p = new Pen(color, 4))
                {
                    e.Graphics.DrawRectangle(p, ClientRectangle);
                }
            }
        }
    }
}
