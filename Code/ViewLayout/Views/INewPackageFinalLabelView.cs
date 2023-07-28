using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Size = System.Drawing.Size;

namespace ViewLayout.Views
{
    public interface INewPackageFinalLabelView : IView
    {
        event Action NewPackage;
        public Size BigBarcodeSize { get; }
        public Size SmallBarcodeSize { get; }
        public string BigBarcodeImage { set; }
        public string SmallBarcodeImage { set; }
    }
}
