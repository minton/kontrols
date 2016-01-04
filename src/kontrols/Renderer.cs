using System.Drawing;
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
    }
}