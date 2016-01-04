using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace kontrols
{
    [DefaultEvent("Click")]
    public partial class HoverImageButton : UserControl
    {
        Color _foreColor;
        Color _hoverForeColor;
        Image _image;
        Image _hoverImage;
        bool _mouseIsOverControl;
        PictureBoxSizeMode _sizeMode;

        public HoverImageButton()
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
            set
            {
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

        /// <summary>
        /// The image used when the mouse is not over the control.
        /// </summary>
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image Image
        {
            get
            {
                return _image;
            }
            set {
                _image = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The image used when the mouse is over the control.
        /// </summary>        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image HoverImage
        {
            get
            {
                return _hoverImage;
            }
            set
            {
                _hoverImage = value;
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
            if (_mouseIsOverControl && _hoverImage != null)
            {
                Renderer.DrawImage(this, graphics, _hoverImage, ClientRectangle, SizeMode);
                return;
            }
            
            if (_image != null)
            {
                Renderer.DrawImage(this, graphics, _image, ClientRectangle, SizeMode);
            }
        }
    }
}
