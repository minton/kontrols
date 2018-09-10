using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace kontrols
{
    [DefaultEvent("Click")]
    public partial class HoverTextButton : UserControl
    {
        bool _hasBorder;
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
            var color = _mouseIsOverControl ? _hoverForeColor : ForeColor;
            TextRenderer.DrawText(graphics, 
                                  Text, 
                                  Font, 
                                  ClientRectangle, 
                                  color, 
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            if (_hasBorder)
            {
                using (var p = new Pen(color, 2))
                {
                    e.Graphics.DrawRectangle(p, 2, 2, Width-4, Height -4);
                }
            }
        }
    }
}
