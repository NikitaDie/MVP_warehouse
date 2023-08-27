using ModelLayout.Models.Package;
using System.IO.Packaging;
using ViewLayout.Views;

namespace Forms.MenuForms.Common
{
    public partial class PackageLabel : Form, ILabelView
    {
        public Size BigBarcodeSize => imgBigBarcode.Size;
        public Size SmallBarcodeSize => new Size(imgSmallBarcode.Size.Height, imgSmallBarcode.Size.Width);
        public string BigBarcodeImage { set => imgBigBarcode.ImageLocation = value; }
        public string SmallBarcodeImage { set => imgSmallBarcode.ImageLocation = value; }
        public PackageLabel()
        {
            InitializeComponent();
        }

        public void LoadData(UserPackage package)
        {
            packageID.Text = package.ID;

            receiverName.Text = package.RecipentName;
            receiverStreet.Text = package.RecipentStreet + @" " + package.RecipentStreet;
            receiverLocation.Text = package.RecipentLocation + @", " + package.RecipentPostCode;
            receiverCountry.Text = package.RecipentCountry;

            senderName.Text = package.SenderName;
            senderStreet.Text = package.SenderStreet + @" " + package.SenderHouseNumber;
            senderLocation.Text = package.SenderLocation + @", " + package.SenderPostCode;
            senderCountry.Text = package.SenderCountry;
        }
    }
}
