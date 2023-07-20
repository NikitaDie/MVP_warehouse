using Forms.MenuForms;
using ModelLayout.Models.User;
using PresenterLayout.Common;
using PresenterLayout.Presenters;
using ServiceLayer.Services.Login;
using ServiceLayout.Services;
using ServiceLayout.Services.GetStartPackages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ViewLayout;
using ViewLayout.Views;

namespace Forms
{
    public partial class MenuForm : Form, IMenuView
    {
        //User user;
        Form currentForm;
        public event Action BackToLoginPage;
        public MenuForm(/*User user*/)
        {
            InitializeComponent();

            back_button.Click += (sender, args) => Invoke(BackToLoginPage);

            var controller = new ApplicationController(new LightInjectAdapder())
               .RegisterView<INewPackageView, NewPackageForm>()
               //.RegisterView<IMenuView, MenuForm>()
               .RegisterService<IGetStartPackagesService, GetStartPackagesService>()
               .RegisterInstance<IBaseView>(this);

            controller.Run<NewPackagePresenter>();
        }
        private new void Invoke(Action action)
        {
            if (action != null) action();
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
            //this.panel_MainLoader.Controls.Clear();
            currentForm = newForm as Form;
            currentForm.Dock = DockStyle.Fill;
            currentForm.TopLevel = false;
            currentForm.TopMost = true;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            this.panel_SectionLoader.Controls.Add(currentForm);
            currentForm.Show();
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
