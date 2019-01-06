using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace kontrols
{
    [Designer(typeof(NonResizableControlDesigner))]
    [DefaultEvent("Click")]
    public partial class DesktopIcon : UserControl
    {
        Image _image;
        Image _disabledImage;
        IconSize _iconSquare;
        bool _scalingForText;
        bool _mouseIsOverControl;
        Color _hoverColor;
        Pen _hoverPen;
        Brush _hoverBrush;
        bool _grayScaleWhenDisabled;

        public enum IconSize
        {
            Square64 = 64,
            Square128 = 128,
            Square256 = 256
        }

        public DesktopIcon()
        {
            InitializeComponent();
            IconSquare = IconSize.Square64;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            UpdateStyles();
            Paint += (_, e) => Render(e.Graphics);
            MouseEnter += (s, e) => { MouseIsOverControl = true; };
            MouseLeave += (s, e) => { MouseIsOverControl = false; };
            EnabledChanged += (s, e) => Invalidate();
        }

        bool MouseIsOverControl
        {
            set
            {
                _mouseIsOverControl = value;
                Invalidate();
            }
        }    

        /// <summary>
        /// The image to display for this item
        /// </summary>
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image Image
        {
            get
            {
                if (Enabled) return _image;
                return _grayScaleWhenDisabled ? _disabledImage : _image;
            }
            set
            {
                _disabledImage = Utility.GrayScale(value);
                _image = value; 
                Invalidate();
            }
        }

        /// <summary>
        /// The color used when the mouse is over the control.
        /// </summary>        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverColor
        {
            get
            {
                return _hoverColor;
            }
            set
            {
                _hoverColor = value;
                _hoverPen = new Pen(_hoverColor.IsEmpty ? SystemColors.Highlight : _hoverColor);
                _hoverBrush = new SolidBrush(Color.FromArgb(100, _hoverPen.Color));
                Invalidate();
            }
        }

        /// <summary>
        /// Determines if the text and image are rendered as gray scale if the button is disabled.
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

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; 
                Size = GetSize();
                Invalidate(); }
        }

        /// <summary>
        /// The icon will be fit into this square while the text string will account for the rest of the space
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [DefaultValue(IconSize.Square64)]
        public IconSize IconSquare
        {
            get => _iconSquare;
            set
            {
                _iconSquare = value;
                Size = GetSize();
                Font = new Font(Font.FontFamily, GetFontSize(), Font.Style);
            }
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            var size = _scalingForText
                ? new Size(width, height)
                : GetSize();
            base.SetBoundsCore(x, y, size.Width, size.Height, specified);
        }

        Size GetSize()
        {
            return new Size((int)IconSquare+26, (int)IconSquare + GetTextPadding());
        }

        int GetTextPadding()
        {
            switch (IconSquare)
            {
                case IconSize.Square64:
                    return 34;
                case IconSize.Square128:
                    return 40;
                case IconSize.Square256:
                    return 60;
                default:
                    return 0;
            }
        }

        float GetFontSize()
        {
            switch (IconSquare)
            {
                case IconSize.Square64:
                    return 10;
                case IconSize.Square128:
                    return 12;
                case IconSize.Square256:
                    return 16;
                default:
                    return 12;
            }
        }

        void Render(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            if (_mouseIsOverControl)
            {
                g.FillRectangle(_hoverBrush ?? SystemBrushes.MenuHighlight, ClientRectangle);
                g.DrawRectangle(_hoverPen ?? SystemPens.Highlight, ClientRectangle);
            }

            var imageRect = new Rectangle(Width/2-(int)IconSquare/2, 0, (int)IconSquare, (int)IconSquare);
            if (Image != null)
                g.DrawImage(Image, imageRect, 0f, 0f, Image.Width, Image.Height, GraphicsUnit.Pixel);
            var textRect = new Rectangle(0, imageRect.Height, Width, Height - imageRect.Height);
            if (string.IsNullOrEmpty(Text)) return;

            var textSize = TextRenderer.MeasureText(g, Text, Font, textRect.Size, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak);

            _scalingForText = true;
            while (textSize.Height > textRect.Height)
            {
                textRect.Height += 1;
                Height += 1;
            }

            _scalingForText = false;

            var foreColor = !Enabled && _grayScaleWhenDisabled
                ? Color.DarkGray
                : ForeColor;

            TextRenderer.DrawText(g,
                Text,
                Font,
                textRect,
                foreColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak | TextFormatFlags.EndEllipsis);
        }
    }
}
