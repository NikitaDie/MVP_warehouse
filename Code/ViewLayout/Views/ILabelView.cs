using ModelLayout.Models.Package;
using Size = System.Drawing.Size;

namespace ViewLayout.Views
{
    public interface ILabelView : IView
    {
        public Size BigBarcodeSize { get; }
        public Size SmallBarcodeSize { get; }
        public string BigBarcodeImage { set; }
        public string SmallBarcodeImage { set; }

        void LoadData(UserPackage userPackage);
    }
}
