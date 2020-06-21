using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace kontrols
{
    public partial class RoundedBorderForm : Form
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

        Pen _borderPen;
        Brush _backgroundBrush;
        Color _backgroundColor;

        [Browsable(true)]
        [DefaultValue(25)]
        public int CornerRadius { get; set; }

        [Browsable(true)]
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                _backgroundColor = value;
                if (_backgroundColor == Color.Empty) _backgroundColor = Color.PapayaWhip;
                _backgroundBrush = new SolidBrush(BackgroundColor);
                _borderPen = new Pen(BackgroundColor, 2);
            }
        }

        [Browsable(true)]
        public bool ShowTitle { get; set; }

        public RoundedBorderForm()
        {
            InitializeComponent();
            TransparencyKey = Color.Lime;
            BackColor = TransparencyKey;
            FormBorderStyle = FormBorderStyle.None;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.High;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RenderForm(e.Graphics);
        }

        void RenderForm(Graphics g)
        {
            Renderer.DrawRoundedRectangle(g, _borderPen, new Rectangle(0, 0, Width, Height - 1), CornerRadius);
            Renderer.FillRoundedRectangle(g, _backgroundBrush, new Rectangle(0, 0, Width, Height - 1), CornerRadius);
            if (ShowTitle)
            {
                TextRenderer.DrawText(g, Text, Font, CaptionArea, ForeColor, BackgroundColor, TextFormatFlags.HorizontalCenter);
            }
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
