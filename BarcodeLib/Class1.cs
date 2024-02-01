using ZXing;
using ZXing.Common;
using System.Drawing;

namespace BarcodeLib
{
    public class BarcodeGenerator
    {
        public Bitmap GenerateBarcode(string content, BarcodeFormat format, int width, int height)
        {
            var writer = new BarcodeWriter
            {
                Format = format,
                Options = new EncodingOptions
                {
                    Height = height,
                    Width = width,
                    Margin = 1
                }
            };

            Bitmap bitmap = writer.Write(content);
            return bitmap;
        }
    }
}
