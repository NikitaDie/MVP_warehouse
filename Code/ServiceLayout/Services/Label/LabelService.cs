using System.Drawing;
using BarcodeStandard;
using SkiaSharp;
using Type = BarcodeStandard.Type;
using Size = System.Drawing.Size;
using ModelLayout.Common;

namespace ServiceLayout.Services.Label
{
    public class LabelService : ILabelService
    {

        public LabelService() { }

        public string TurnBarcodeVerticaly(string path)
        {
            var bitmap1 = (Bitmap)System.Drawing.Bitmap.FromFile(path);
                bitmap1.RotateFlip(RotateFlipType.Rotate180FlipY);



            bitmap1.Save(path, System.Drawing.Imaging.ImageFormat.Png);

            bitmap1.Dispose();

            return path;
        }

        public string GetBarcode(string label, Size size)
        {
            Barcode b = new Barcode();
            SkiaSharp.SKColorF foreColor = new SKColorF(255, 255, 255);
            SkiaSharp.SKColorF backColor = new SKColorF(0, 0, 0, 0);
            SKImage img = b.Encode(Type.UpcA, label, foreColor, backColor, size.Width, size.Height);

            SKData encodedData = img.Encode(SKEncodedImageFormat.Png, 100);
            string imagePath = Path.Combine(GetCacheDirectory(), $"barcode{size.Width}x{size.Height}.png");
            var bitmapImageStream = File.Open(imagePath,
                FileMode.Create,
                FileAccess.Write,
                FileShare.None);
            encodedData.SaveTo(bitmapImageStream);
            bitmapImageStream.Flush(true);
            bitmapImageStream.Dispose();

            return imagePath;
        }
        private string GetCacheDirectory()
        {
            // Get the path to the Cache directory in the user's local application data folder
            string cacheDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cache");

            // Check if the Cache directory exists, and create it if it doesn't
            if (!Directory.Exists(cacheDir))
            {
                Directory.CreateDirectory(cacheDir);
            }

            return cacheDir;
        }
    }
}
