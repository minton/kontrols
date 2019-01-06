using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace kontrols
{
    public partial class ZoomMenu : UserControl
    {
        private BindingList<ZoomItem> _items;
        private int _columns;
        Color _foreColor;
        Color _hoverForeColor;

        public ZoomMenu()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.UserPaint , true);
            UpdateStyles();
            _items = new BindingList<ZoomItem>();
            _items.ListChanged += (_, __) => Populate();
            Resize += (_, __) => Populate();
        }

        /// <summary>
        /// The collection of items to display on the Zoom Menu control
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BindingList<ZoomItem> Items => _items;

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
                Populate();
            }
        }

        void Populate()
        {
            tmr.Stop();
            while (Controls.Count > 0)
            {
                if (Controls[0] == null) break;

                Controls[0].Dispose();
            }

            if (Items.Count == 0) return;

            var margin = (int) (Screen.PrimaryScreen.Bounds.Width * .05);
            var size = 128;
            var gap = 64;
            var startingX = margin / 2;
            var currentX = startingX;
            var currentY = (int) (Screen.PrimaryScreen.Bounds.Height * .025);

            foreach (var item in Items)
            {
                var box = new PictureBox
                {
                    Left = currentX,
                    Top = currentY,
                    Image = item.Image,
                    Height = size,
                    Width = size,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Transparent,
                    Enabled =  Enabled
                };
                var label = new LinkLabel
                {
                    BackColor = Color.Transparent,
                    Text = item.Text,
                    Left = box.Left,
                    Top = box.Top + box.Height + 10,
                    Width = box.Width,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = Font,
                    LinkColor = ForeColor,
                    LinkBehavior = LinkBehavior.HoverUnderline,
                    Enabled =  Enabled
                };
                label.Height = label.Height*3;
                box.Tag = label;

                box.MouseDown += BoxOnMouseDown;
                box.MouseUp += BoxOnMouseUp;
                box.MouseEnter += BoxOnMouseEnter;
                box.MouseLeave += BoxOnMouseLeave;
                label.Click += LabelOnClick;

                Controls.Add(box);
                Controls.Add(label);

                currentX += size + gap;
                if (Width - (currentX +(gap*.5)) <= margin)
                {
                    currentY += size + gap*2;
                    currentX = startingX;
                }
            }
            tmr.Start();
        }

        private void LabelOnClick(object sender, EventArgs e)
        {
        }

        private void BoxOnMouseLeave(object sender, EventArgs e)
        {
        }

        private void BoxOnMouseEnter(object sender, EventArgs e)
        {
        }

        private void BoxOnMouseUp(object sender, MouseEventArgs e)
        {
        }

        private void BoxOnMouseDown(object sender, MouseEventArgs e)
        {
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            if (DesignMode) return;

            var startSize = 128;
            foreach (Control control in Controls)
            {
                if (!(control is PictureBox box)) continue;

                var x = (box.Left + (box.Width / 2)) - PointToClient(Cursor.Position).X;
                x = 57 - Math.Abs(x);

                var y = (box.Top + box.Height / 2) - PointToClient(Cursor.Position).Y;
                y = 57 - Math.Abs(y);

                if (x > -50 && y > -50)
                {
                    var num = (x + y) / 2 + startSize;
                    var newSize = num < startSize ? startSize : num;
                    box.Width = newSize;
                    box.Height = newSize;
                }
                else
                {
                    box.Height = startSize;
                    box.Width = startSize;
                }

                if (!(box.Tag is LinkLabel label)) continue;

                label.Top = box.Top + box.Height + 10;
                label.Width = box.Width;
                label.Left = box.Left;
            }
        }

        public void Add(Bitmap image, string caption)
        {
            Items.Add(new ZoomItem {Image = image, Text = caption});
        }
    }

    public class ZoomItem
    {
        /// <summary>
        /// The image to display for this item
        /// </summary>
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image Image { get; set; }

        /// <summary>
        /// The text to display for this item
        /// </summary>
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Text { get; set; }
    }
}
