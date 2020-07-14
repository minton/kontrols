using System.Drawing;
using System.Drawing.Imaging;

namespace kontrols
{
    public class Utility
    {
        public static Image GrayScale(Image original)
        {
            if (original == null) return null;

            var newBitmap = new Bitmap(original.Width, original.Height);
            var g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            var colorMatrix = new ColorMatrix(new[]{
                new[] {.3f, .3f, .3f, 0, 0},
                new[] {.59f, .59f, .59f, 0, 0},
                new[] {.11f, .11f, .11f, 0, 0},
                new[] {0f, 0, 0, 1, 0},
                new[] {0f, 0, 0, 0, 1}
            });

            var attributes = new ImageAttributes();
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image using the grayscale color matrix
            g.DrawImage(original, 
                new Rectangle(0, 0, original.Width, original.Height), 
                0, 
                0, 
                original.Width,
                original.Height, 
                GraphicsUnit.Pixel, 
                attributes);

            g.Dispose();
            return newBitmap;
        }
    }
}