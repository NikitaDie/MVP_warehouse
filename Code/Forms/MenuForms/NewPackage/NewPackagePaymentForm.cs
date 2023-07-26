using ModelLayout.Models.Package;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewLayout.Views;

namespace Forms.MenuForms.NewPackage
{
    public partial class NewPackagePaymentForm : Form, INewPackagePaymentView
    {
        public NewPackagePaymentForm()
        {
            InitializeComponent();

            btnPay.Click += (sender, argc) => Invoke(Pay);
            changePackageButton.Click += (sender, argc) => Invoke(ReturnToNewPackagePage);
            changeReceiverButton.Click += (sender, argc) => Invoke(ReturnToNewPackageUserDataPage);
            changeSenderButton.Click += (sender, argc) => Invoke(ReturnToNewPackageUserDataPage);

        }

        public event Action? Pay;
        public event Action? ReturnToNewPackagePage;
        public event Action? ReturnToNewPackageUserDataPage;

        private new void Invoke(Action? action)
        {
            try
            {
                action?.Invoke();
            }
            catch { throw; };
        }
        public void LoadPackageInfo(UserPackage package)
        {
            packageName.Text = package.Name;
            packageDescription.Text = $"max. {package.SizeDescription.Width} x {package.SizeDescription.Length} x {package.SizeDescription.Height} cm";
            packagePrice.Text = $"{package.Price} €";

            receiverName.Text = package.RecipentName;
            receiverStreet.Text = $"{package.RecipentStreet} {package.RecipentHouseNumber}";
            receiverLocation.Text = $"{package.RecipentPostCode} {package.RecipentLocation}";
            receiverCountry.Text = "Germany";

            senderName.Text = package.SenderName;
            senderStreet.Text = $"{package.SenderStreet} {package.SenderHouseNumber}";
            senderLocation.Text = $"{package.SenderPostCode} {package.SenderLocation}";
            senderCountry.Text = "Germany";

        }

        private void receiverName_Click(object sender, EventArgs e)
        {

        }
    }
}
