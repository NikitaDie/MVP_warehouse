using BarcodeStandard;
using SkiaSharp;
using Type = BarcodeStandard.Type;

namespace ServiceLayout.Services.Label
{
    public class LabelService : ILabelService
    {

        public LabelService() { }

        public string GetBarcode(string label)
        {
            Barcode b = new Barcode();
            SkiaSharp.SKColorF foreColor = new SKColorF(255, 255, 255);
            SkiaSharp.SKColorF backColor = new SKColorF(0, 0, 0, 0);
            SKImage img = b.Encode(Type.UpcA, label, foreColor, backColor, 300, 100);

            SKData encodedData = img.Encode(SKEncodedImageFormat.Png, 100);
            string imagePath = Path.Combine(GetCacheDirectory(), "barcode.png");
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
