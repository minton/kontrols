using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace kontrols
{
    [DefaultEvent("Click")]
    public partial class ToggleImageButton : UserControl
    {
        Color _foreColor;
        Color _hoverForeColor;
        Image _image;
        Image _toggledImage;
        bool _mouseIsOverControl;
        bool _toggled;
        PictureBoxSizeMode _sizeMode;
        Image _disabledImage;
        Image _disabledToggleImage;
        bool _grayScaleWhenDisabled;

        public ToggleImageButton()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint , true);
            UpdateStyles();
            Paint += Render;
            MouseEnter += (s, e) => { MouseIsOverControl = true; };
            MouseLeave += (s, e) => { MouseIsOverControl = false; };
            Click += (s, e) => { Toggled = !Toggled; };
            EnabledChanged += (s, e) => Invalidate();
        }

        /// <summary>
        /// Determines if the image is renders as gray scale if the button is disabled.
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
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override Color ForeColor
        {
            get
            {
                return _foreColor;
            }
            set
            {
                _foreColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The color used when the mouse is over the control.
        /// </summary>        
        [EditorBrowsable(EditorBrowsableState.Always)]
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

        /// <summary>
        /// The image used when the control is not toggled.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
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
        /// The image used when the control is toggled.
        /// </summary>        
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image ImageToggled
        {
            get
            {
                if (Enabled) return _toggledImage;

                return _grayScaleWhenDisabled ? _disabledToggleImage : _toggledImage;
            }
            set
            {
                _disabledToggleImage = Utility.GrayScale(value);
                _toggledImage = value;
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

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof (PictureBoxSizeMode), "Normal")]
        public PictureBoxSizeMode SizeMode
        {
            get { return _sizeMode; }
            set { _sizeMode = value; Invalidate(); }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public bool Toggled
        {
            get { return _toggled;}
            set { _toggled = value; Invalidate(); }
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

            RenderImage(graphics);

            if (string.IsNullOrEmpty(Text)) return;

            Renderer.DrawText(graphics, Text, Font, ClientRectangle, _mouseIsOverControl ? _hoverForeColor : _foreColor);
        }

        void RenderImage(Graphics graphics)
        {            
            if (_toggled && _toggledImage != null)
            {
                Renderer.DrawImage(this, graphics, ImageToggled, ClientRectangle, SizeMode);
                return;
            }
            
            if (_image != null)
            {
                Renderer.DrawImage(this, graphics, Image, ClientRectangle, SizeMode);
            }
        }
    }
}
