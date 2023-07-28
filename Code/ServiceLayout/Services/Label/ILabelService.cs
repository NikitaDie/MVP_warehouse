using Size = System.Drawing.Size;

namespace ServiceLayout.Services.Label
{
    public interface ILabelService
    {
        public string TurnBarcodeVerticaly(string path);
        public string GetBarcode(string label, Size size);
    }
}
