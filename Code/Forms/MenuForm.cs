using Forms.MenuForms;
using Forms.MenuForms.NewPackage;
using ModelLayout.Models.User;
using ViewLayout;
using ViewLayout.Views;

namespace Forms
{
    public partial class MenuForm : Form, IMenuView
    {
        //User user;
        public IView CurrentForm { get; set; }
        public event Action BackToLoginPage;
        public event Action LaunchNewPackage;
        public event Action LaunchSearchPackage;

        public MenuForm(/*User user*/)
        {
            InitializeComponent();

            back_button.Click += (sender, args) => Invoke(BackToLoginPage);
            btnNewPackage.Click += (sender, args) => Invoke(LaunchNewPackage); //Container
            btnSearchPackage.Click += (sender, args) => Invoke(LaunchSearchPackage);

        }

        private new void Invoke(Action? action)
        {
            action?.Invoke();
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
                //HookOnCompletionInUiThread(this, () => Invoke(LaunchNewPackage)).
                Accelerate(TimeSpan.FromMilliseconds(200));
        }

        public new void Close()
        {
            FluentTransitions.Transition.With(this, nameof(Y), Location.Y - Height).
                HookOnCompletionInUiThread(this, () => base.Close()).
                Accelerate(TimeSpan.FromMilliseconds(200));
        }

        public void LoadUserSettings(IUserModel user)
        {
            label_Username.Text = user.Name;
            label_Role.Text = user.Role.ToString();

            if (user.Role == Roles.admin)
            {
                //user = new Admin(unitID);
                panel_AdminBtns.Visible = true;
            }
            else
            {
                //user = new User(unitID);
                string rb = "";
            }
        }

        public void LoadNewForm(IView newForm)
        {
            Form _currentForm = newForm as Form;
            //this.panel_MainLoader.Controls.Clear();
            //currentForm.Dock = DockStyle.Fill;
            _currentForm.TopLevel = false;
            _currentForm.TopMost = true;
            _currentForm.FormBorderStyle = FormBorderStyle.None;
            this.panel_SectionLoader.Controls.Add(_currentForm);

            CurrentForm = newForm;
            newForm.Show();
        }

        /*public void NewForm(Form newForm) //abstract class
        {

            this.panel_SectionLoader.Controls.Clear();
            currentForm = newForm;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            this.panel_SectionLoader.Controls.Add(currentForm);
            currentForm.Show();
        }*/
    }
}
