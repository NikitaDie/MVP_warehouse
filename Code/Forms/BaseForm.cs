using PresenterLayout.Common;
using PresenterLayout.Presenters;
using ServiceLayer.Services.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewLayout;
using ViewLayout.Views;

namespace Forms
{
    public partial class BaseForm : Form, IBaseView
    {
        Form currentForm;
        public BaseForm()
        {
            InitializeComponent();

            var controller = new ApplicationController(new LightInjectAdapder())
                .RegisterView<ILoginView, LoginForm>()
                .RegisterView<IMenuView, MenuForm>()
                //.RegisterView<IMainView, MainForm>()
                //.RegisterView<IChangeUsernameView, ChangeUsernameForm>()
                .RegisterService<ILoginService, LoginService>()
                .RegisterInstance<IBaseView>(this);

            controller.Run<LoginPresenter>();
        }

        public void LoadNewForm(IView newForm)
        {
            //this.panel_MainLoader.Controls.Clear();
            currentForm = newForm as Form;
            currentForm.Dock = DockStyle.Fill;
            currentForm.TopLevel = false;
            currentForm.TopMost = true;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            this.panel_MainLoader.Controls.Add(currentForm);
            currentForm.Show();
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
