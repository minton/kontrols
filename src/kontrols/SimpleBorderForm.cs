using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace kontrols
{
    public partial class SimpleBorderForm : Form
    {
        const int CaptionHeight = 32;
        const int ResizableArea = 20;
        const int WM_NCHITEST = 0x84;

        public static IntPtr HTCAPTION => (IntPtr)2;
        public static IntPtr HTLEFT => (IntPtr)10;
        public static IntPtr HTRIGHT => (IntPtr)11;
        public static IntPtr HTTOP => (IntPtr)12;
        public static IntPtr HTTOPLEFT => (IntPtr)13;
        public static IntPtr HTTOPRIGHT => (IntPtr)14;
        public static IntPtr HTBOTTOM => (IntPtr)15;
        public static IntPtr HTBOTTOMLEFT => (IntPtr)16;
        public static IntPtr HTBOTTOMRIGHT => (IntPtr)17;

        Color _borderColor;
        Color _hoverControlBoxForeColor;
        Color _hoverControlBoxBackColor;

        [Browsable(true)]
        public bool ShowTitle { get; set; }

        public SimpleBorderForm()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Load += (_, __) =>
            {
                if (!ControlBox)
                {
                    btnClose.Visible =
                        btnMinimize.Visible =
                            btnMaximize.Visible = false;
                    return;
                }

                SetupButton(btnClose, DrawCloseButton);
                SetupButton(btnMaximize, DrawMaximizeButton);
                SetupButton(btnMinimize, DrawMinimizeButton);
            };
            btnClose.Click += (_, __) => Close();
            btnMaximize.Click += (_, __) => WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            btnMinimize.Click += (_, __) => WindowState = FormWindowState.Minimized;
        }

        void SetupButton(HoverImageButton button, Func<Color, Image> getImage) 
        {
            button.BorderStyle = BorderStyle.None;
            button.Image = getImage(BorderColor);
            button.HoverImage = getImage(BackColor);
            button.HoverBackColor = BorderColor;
            button.HoverForeColor = BackColor;
            button.SizeMode = PictureBoxSizeMode.Normal;
        }

        Image DrawCloseButton(Color color)
        {
            var img = new Bitmap(25, 25);
            var g = Graphics.FromImage(img);
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.HighQuality;
            using var p = new Pen(color, 1);
            g.DrawLine(p, 7, 7, 15, 15);
            g.DrawLine(p, 7, 15, 15, 7);
            return img;
        }

        Image DrawMaximizeButton(Color color)
        {
            var img = new Bitmap(25, 25);
            var g = Graphics.FromImage(img);
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.HighQuality;
            using var p = new Pen(color, 1);
            g.DrawRectangle(p, 9, 5, 10, 10);
            g.DrawRectangle(p, 7, 7, 10, 10);
            return img;
        }
        Image DrawMinimizeButton(Color color)
        {
            var img = new Bitmap(25, 25);
            var g = Graphics.FromImage(img);
            g.InterpolationMode = InterpolationMode.HighQualityBilinear;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.HighQuality;
            using var p = new Pen(color, 1);
            g.DrawLine(p, 9, 7, 18, 7);
            return img;
        }

        public Color BorderColor
        {
            get => _borderColor.IsEmpty ? Color.Orange : _borderColor;
            set
            {
                _borderColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The ForeColor used when the mouse is over the control box.
        /// </summary>        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverControlBoxForeColor
        {
            get => _hoverControlBoxForeColor.IsEmpty ? BackColor : _hoverControlBoxForeColor;
            set
            {
                _hoverControlBoxForeColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The BackColor used when the mouse is over the control box.
        /// </summary>        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverControlBoxBackColor
        {
            get => _hoverControlBoxBackColor.IsEmpty ? BackColor : _hoverControlBoxBackColor;
            set
            {
                _hoverControlBoxBackColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.High;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (ShowTitle)
            {
                TextRenderer.DrawText(e.Graphics, Text, Font, CaptionArea, ForeColor, BackColor, TextFormatFlags.HorizontalCenter);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            using var p = new Pen(BorderColor, 2);
            e.Graphics.DrawRectangle(p, 2, 2, Width - 4, Height - 4);
        }

        Rectangle CaptionArea => new Rectangle(24, 4, ClientSize.Width - 48, CaptionHeight);
        Rectangle TopSizeArea => new Rectangle(0, 0, ClientSize.Width, ResizableArea);
        Rectangle LeftSizeArea => new Rectangle(0, 0, ResizableArea, ClientSize.Height);
        Rectangle BottomSizeArea => new Rectangle(0, ClientSize.Height - ResizableArea, ClientSize.Width, ResizableArea);
        Rectangle RightSizeArea => new Rectangle(ClientSize.Width - ResizableArea, 0, ResizableArea, ClientSize.Height);
        Rectangle TopLeftSizeArea => new Rectangle(0, 0, ResizableArea, ResizableArea);
        Rectangle TopRightSizeArea => new Rectangle(ClientSize.Width - ResizableArea, 0, ResizableArea, ResizableArea);
        Rectangle BottomLeftSizeArea => new Rectangle(0, ClientSize.Height - ResizableArea, ResizableArea, ResizableArea);
        Rectangle BottomRightSizeArea => new Rectangle(ClientSize.Width - ResizableArea, ClientSize.Height - ResizableArea, ResizableArea, ResizableArea);

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg != WM_NCHITEST) return;

            var cursorPosition = PointToClient(new Point(m.LParam.ToInt32()));
            if (CaptionArea.Contains(cursorPosition)) m.Result = HTCAPTION;
            else if (TopLeftSizeArea.Contains(cursorPosition)) m.Result = HTTOPLEFT;
            else if (TopRightSizeArea.Contains(cursorPosition)) m.Result = HTTOPRIGHT;
            else if (BottomLeftSizeArea.Contains(cursorPosition)) m.Result = HTBOTTOMLEFT;
            else if (BottomRightSizeArea.Contains(cursorPosition)) m.Result = HTBOTTOMRIGHT;
            else if (TopSizeArea.Contains(cursorPosition)) m.Result = HTTOP;
            else if (LeftSizeArea.Contains(cursorPosition)) m.Result = HTLEFT;
            else if (RightSizeArea.Contains(cursorPosition)) m.Result = HTRIGHT;
            else if (BottomSizeArea.Contains(cursorPosition)) m.Result = HTBOTTOM;
        }
    }
}
