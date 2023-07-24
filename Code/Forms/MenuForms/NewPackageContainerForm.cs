using Guna.UI2.WinForms;
using PresenterLayout.Common;
using PresenterLayout.Presenters;
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
using ViewLayout;
using ViewLayout.Views;

namespace Forms.MenuForms
{
    public partial class NewPackageContainerForm : Form, INewPackageContainerView
    {
        Form currentForm;
        public NewPackageContainerForm()
        {
            InitializeComponent();

            var controller = new ApplicationController(new LightInjectAdapder())
               .RegisterView<INewPackageView, NewPackageForm>()
               .RegisterView<INewPackageUserDataView, NewPackageUserDataForm>()
               .RegisterService<IGetStartPackagesService, GetStartPackagesService>()
               .RegisterInstance<IBaseView>(this);

            SetProgressBar(0);

            controller.Run<NewPackagePresenter>();
        }

        public void LoadNewForm(IView newForm)
        {
            //this.panel_MainLoader.Controls.Clear();
            currentForm = newForm as Form;
            currentForm.Dock = DockStyle.Fill;
            currentForm.TopLevel = false;
            currentForm.TopMost = true;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            this.panel_Loader.Controls.Add(currentForm);
            currentForm.Show();
        }

        public void SetProgressBar(int step)
        {
            for (int i = 0; i < ProgressBar_tableLayoutPanel.ColumnCount; ++i)
            {
                Control control = ProgressBar_tableLayoutPanel.GetControlFromPosition(i, 0);
                int j = (int)Math.Round((double)(i + 1) / 2, MidpointRounding.AwayFromZero);

                if (control is Guna2CircleProgressBar)
                {
                    Guna2CircleProgressBar circleProgressBar = control as Guna2CircleProgressBar;
                    circleProgressBar.Value = 0;

                    if (j == step)
                    {
                        circleProgressBar.FillColor = Color.FromArgb(212, 5, 17);
                        circleProgressBar.InnerColor = Color.FromArgb(212, 5, 17);
                        circleProgressBar.ForeColor = Color.White;
                    }
                    else if (j > step)
                    {
                        circleProgressBar.FillColor = Color.FromArgb(200, 213, 218, 223);
                        circleProgressBar.InnerColor = Color.Transparent;
                        circleProgressBar.ForeColor = Color.FromArgb(102, 102, 102);
                    }
                    else
                    {
                        circleProgressBar.FillColor = Color.FromArgb(72, 180, 81);
                        circleProgressBar.InnerColor = Color.Transparent;
                        circleProgressBar.ForeColor = Color.FromArgb(72, 180, 81);
                    }
                }
                else if (control is Guna2ProgressBar)
                {
                    Guna2ProgressBar ProgressBar = control as Guna2ProgressBar;
                    ProgressBar.Value = 0;

                    if (j >= step)
                    {
                        ProgressBar.FillColor = Color.FromArgb(200, 213, 218, 223);
                    }
                    else
                    {
                        ProgressBar.FillColor = Color.FromArgb(72, 180, 81);
                    }
                }

            }
        }

    }
}
