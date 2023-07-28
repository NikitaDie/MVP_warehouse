using Guna.UI2.WinForms;
using ViewLayout;
using ViewLayout.Views;


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

        public event Action? NextPage;

        public NewPackageUserDataForm()
        {
            InitializeComponent();

            btnNextPage.Click += (send, args) => ManagePagesButtonBehavior();
        }

        void IView.Show()
        {
            FluentTransitions.Transition.With(this.Location, nameof(Location.X), Location.X + Width).
                HookOnCompletionInUiThread(this, () => base.Show()).
                Accelerate(TimeSpan.FromMilliseconds(200));
        }

        private new static void Invoke(Action? action)
        {
            try
            {
                action?.Invoke();
            }
            catch
            {
                throw;
            }
        }

        private void ManagePagesButtonBehavior()
        {
            if (IsComplete())
                Invoke(NextPage);
            //else Popup?
        }

        private bool IsComplete() //too much, rename, delegate?
        {
            bool isComplete = true;
            try
            {
                foreach (Panel panel in ReceiverTextboxPanel.Controls)
                {
                    foreach (Control control in panel.Controls)
                    {
                        if (control is not Guna2TextBox textBox) continue;

                        if (textBox.Text != "") continue;

                        textBox.BorderColor = Color.Red;
                        textBox.TextChanged += (send, args) => textBox.BorderColor = Color.Black;
                        isComplete = false;
                    }
                }

                foreach (Panel panel in SenderTextboxPanel.Controls)
                {
                    foreach (Control control in panel.Controls)
                    {
                        if (control is not Guna2TextBox textBox) continue;

                        if (textBox.Text != "") continue;

                        textBox.BorderColor = Color.Red;
                        textBox.TextChanged += (send, args) => textBox.BorderColor = Color.Black;
                        isComplete = false;
                    }
                }
            }
            catch
            {
                return false;
                //?
            }

            return isComplete;
        }
    }
}
