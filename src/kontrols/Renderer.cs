using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace kontrols
{
    public class Renderer
    {
        public static void DrawText(Graphics graphics, string Text, Font Font, Rectangle ClientRectangle, Color color)
        {
            TextRenderer.DrawText(graphics,
                                 Text,
                                 Font,
                                 ClientRectangle,
                                 color,
                                 TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        public static void DrawImage(Control control, Graphics graphics, Image image, Rectangle bounds, PictureBoxSizeMode sizeMode)
        {
            switch (sizeMode)
            {
                case PictureBoxSizeMode.Normal:
                    graphics.DrawImageUnscaled(image, bounds);
                    break;
                case PictureBoxSizeMode.StretchImage:
                    graphics.DrawImage(image, bounds);
                    break;
                case PictureBoxSizeMode.AutoSize:
                    control.Size = image.Size;
                    graphics.DrawImageUnscaled(image, bounds);
                    break;
                case PictureBoxSizeMode.CenterImage:
                    var centeredRectangle = new Rectangle(Half(control.Width) - Half(image.Width),
                                                          Half(control.Height) - Half(image.Height),
                                                          image.Width, image.Height);
                    graphics.DrawImageUnscaled(image, centeredRectangle);
                    break;
                case PictureBoxSizeMode.Zoom:
                    DrawImageZoomMode(graphics, image, bounds);
                    break;
            }
        }

        static void DrawImageZoomMode(Graphics graphics, Image image, Rectangle bounds)
        {
            var r1 = (decimal)image.Width / image.Height;
            var r2 = (decimal)bounds.Width / bounds.Height;
            var w = bounds.Width;
            var h = bounds.Height;
            if (r1 > r2)
            {
                w = bounds.Width;
                h = (int)(w / r1);
            }
            else if (r1 < r2)
            {
                h = bounds.Height;
                w = (int)(r1 * h);
            }
            var x = Half(bounds.Width - w);
            var y = Half(bounds.Height - h);
            graphics.DrawImage(image, new Rectangle(x, y, w, h));
        }

        static int Half(int input)
        {            
            return input / 2;
        }

        public static void DrawRoundedRectangle(Graphics graphics, Pen pen, Rectangle bounds, int cornerRadius)
        {
            using var path = RoundedRect(bounds, cornerRadius);
            graphics.DrawPath(pen, path);
        }

        public static void FillRoundedRectangle(Graphics graphics, Brush brush, Rectangle bounds, int cornerRadius)
        {
            using var path = RoundedRect(bounds, cornerRadius);
            graphics.FillPath(brush, path);
        }

        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            var diameter = radius * 2;
            var size = new Size(diameter, diameter);
            var arc = new Rectangle(bounds.Location, size);
            var path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}