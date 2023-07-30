using ViewLayout.Views;

namespace Forms
{
    public partial class LoginForm : Form, ILoginView
    {
        public string Username { get { return textBox_login.Text; } }
        public string Password { get { return textBox_password.Text; } }

        public event Action Login;

        public LoginForm()
        {
            InitializeComponent();
            SetButton();
            //textBox_login.Text = BCrypt.Net.BCrypt.HashPassword("user");
            login_button.Click += (sender, args) => Invoke(Login);
        }

        private new void Invoke(Action action)
        {
            if (action != null) action();
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

        private void SetButton()
        {
            if (textBox_login.Text != "" && textBox_password.Text != "")
                login_button.Enabled = true;
            else
                login_button.Enabled = false;
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {

            SetButton();
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void textBox_password_Enter(object sender, EventArgs e)
        {
            panel_password.BackColor = Color.Aqua;
        }

        private void textBox_password_Leave(object sender, EventArgs e)
        {
            panel_password.BackColor = Color.DarkGray;
        }
        private void textBox_login_Enter(object sender, EventArgs e)
        {
            panel_login.BackColor = Color.Aqua;
        }

        private void textBox_login_Leave(object sender, EventArgs e)
        {
            panel_login.BackColor = Color.DarkGray;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel_MainLoader.Focus();
        }

        public void ShowError(string errorMessage)
        {
            throw new NotImplementedException();
        }
    }
}