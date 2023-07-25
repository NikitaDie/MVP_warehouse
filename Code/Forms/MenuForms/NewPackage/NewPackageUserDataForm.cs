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
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms.MenuForms.NewPackage
{
    public partial class NewPackageUserDataForm : Form, INewPackageUserDataView
    {
        public string RecipentName => recipentName_textBox.Text;
        public string RecipentPostCode => recipentPostCode_textBox.Text;
        public string RecipentLocation => recipentLocation_textBox.Text;
        public string RecipentStreet => recipentStreet_textBox.Text;
        public string RecipentHouseNumber => recipentHouseNumber_textBox.Text;
        public string RecipentEmail => recipentEmail_textBox.Text;
        public string SenderName => senderName_textBox.Text;
        public string SenderPostCode => senderPostCode_textBox.Text;
        public string SenderLocation => senderLocation_textBox.Text;
        public string SenderStreet => senderStreet_textBox.Text;
        public string SenderHouseNumber => senderHouseNumber_textBox.Text;
        public string SenderEmail => senderEmail_textBox.Text;

        public event Action NextPage;
        public NewPackageUserDataForm()
        {
            InitializeComponent();

            btnNextPage.Click += (send, args) => Invoke(NextPage);
        }

        private new static void Invoke(Action action)
        {
            try
            {
                if (action != null) action();
            }
            catch { throw; };
        }


    }
}
