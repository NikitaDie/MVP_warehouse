using ViewLayout;
using ViewLayout.Views;

namespace Main
{
    public partial class BaseForm : Form, IBaseView
    {
        Form? currentForm;
        public BaseForm()
        {
            InitializeComponent();

        }

        public new void Show()
        {
            Application.Run(this);
        }

        public void LoadNewForm(IView newForm)
        {
            //this.panel_MainLoader.Controls.Clear();
            currentForm = newForm as Form;
            //currentForm.Dock = DockStyle.Fill;
            currentForm.TopLevel = false;
            currentForm.TopMost = true;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            this.panel_MainLoader.Controls.Add(currentForm);
            newForm.Show();
        }

        /*public void NewForm(Form newForm)
        {
            this.panel_MainLoader.Controls.Clear();
            currentForm = newForm;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            this.panel_MainLoader.Controls.Add(currentForm);
            currentForm.Show();
        }*/
    }
}
