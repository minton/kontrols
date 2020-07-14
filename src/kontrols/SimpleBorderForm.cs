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

        [Browsable(true)]
        public bool ShowTitle { get; set; }

        public SimpleBorderForm()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
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
            using var p = new Pen(_borderColor.IsEmpty ? Color.Orange : _borderColor, 2);
            e.Graphics.DrawRectangle(p, 2, 2, Width-4, Height -4);
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
