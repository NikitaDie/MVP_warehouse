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
        public string RecipentName
        {
            get => recipentName_textBox.Text;
            set => recipentName_textBox.Text = value;
        }

        public string RecipentPostCode
        {
            get => recipentPostCode_textBox.Text;
            set => recipentPostCode_textBox.Text = value;
        }

        public string RecipentLocation
        {
            get => recipentLocation_textBox.Text;
            set => recipentLocation_textBox.Text = value;
        }

        public string RecipentStreet
        {
            get => recipentStreet_textBox.Text;
            set => recipentStreet_textBox.Text = value;
        }

        public string RecipentHouseNumber
        {
            get => recipentHouseNumber_textBox.Text;
            set => recipentHouseNumber_textBox.Text = value;
        }

        public string RecipentEmail
        {
            get => recipentEmail_textBox.Text;
            set => recipentEmail_textBox.Text = value;
        }

        public string SenderName
        {
            get => senderName_textBox.Text;
            set => senderName_textBox.Text = value;
        }

        public string SenderPostCode
        {
            get => senderPostCode_textBox.Text;
            set => senderPostCode_textBox.Text = value;
        }

        public string SenderLocation
        {
            get => senderLocation_textBox.Text;
            set => senderLocation_textBox.Text = value;
        }

        public string SenderStreet
        {
            get => senderStreet_textBox.Text;
            set => senderStreet_textBox.Text = value;
        }

        public string SenderHouseNumber
        {
            get => senderHouseNumber_textBox.Text;
            set => senderHouseNumber_textBox.Text = value;
        }

        public string SenderEmail
        {
            get => senderEmail_textBox.Text;
            set => senderEmail_textBox.Text = value;
        }

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
