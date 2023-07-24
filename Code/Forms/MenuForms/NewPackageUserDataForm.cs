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

namespace Forms.MenuForms
{
    public partial class NewPackageUserDataForm : Form, INewPackageUserDataView
    {
        public event Action FindLocation;
        public event Action FindWarehouse;

        public string Location { get; set; }
        public string Warehouse { get; set; }
        public string TmpLocation { get; set; }
        public string TmpWarehouse { get; set; }
        public NewPackageUserDataForm()
        {
            InitializeComponent();

            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
            autoCompleteData.AddRange(new string[]
            {
                "Apple",
                "Apple2",
                "Apple3",
                "Apple4",
                "Apple5",
                "Apple6",
                "Apple7",
                "Banana",
                "Orange",
                "Grapes",
                "Pineapple"
                // Добавьте здесь другие варианты по вашему усмотрению.
            });


            cityTown_textBox.TextChanged += (sender, args) => Location = cityTown_textBox.Text;
            cityTown_textBox.TextChanged += (sender, args) => Invoke(FindLocation);
        }
        private new void Invoke(Action action)
        {
            try
            {
                if (action != null) action();
            }
            catch { throw; };
        }


    }
}
