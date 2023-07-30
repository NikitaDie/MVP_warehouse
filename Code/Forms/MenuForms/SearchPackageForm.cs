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

namespace Forms.MenuForms
{
    public partial class SearchPackageForm : Form, ISearchPackageView
    {
        public SearchPackageForm()
        {
            InitializeComponent();
        }

        public int Y
        {
            get => Location.Y;
            set => Location = Location with { Y = value };
        }

        public new void Show()
        {
            Location = new Point(Location.X, Location.Y + Height);
            base.Show();
            FluentTransitions.Transition.With(this, nameof(Y), 0).
                Accelerate(TimeSpan.FromMilliseconds(200));
        }

        public new void Close()
        {
            FluentTransitions.Transition.With(this, nameof(Y), Location.Y - Height).
                HookOnCompletionInUiThread(this, () => base.Close()).
                Accelerate(TimeSpan.FromMilliseconds(200));
        }

    }
}
