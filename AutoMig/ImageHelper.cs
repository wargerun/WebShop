using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace AutoMig
{
    public static class ImageHelper
    {
        public static byte[] GetBytesFromImage(string filePath)
        {
            using (Image image = Image.FromFile(filePath))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
        }
    }
}