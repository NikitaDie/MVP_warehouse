using Guna.UI2.WinForms;
using PresenterLayout.Common;
using PresenterLayout.Presenters;
using ServiceLayout.Services.GetStartPackages;
using ViewLayout;
using ViewLayout.Views;

namespace Forms.MenuForms.NewPackage
{
    public partial class NewPackageContainerForm : Form, INewPackageContainerView
    {
        Form? _currentForm;
        public NewPackageContainerForm()
        {
            InitializeComponent();

            var controller = new ApplicationController(new LightInjectAdapder())
                .RegisterView<INewPackageView, NewPackageForm>()
                .RegisterView<INewPackageUserDataView, NewPackageUserDataForm>()
                .RegisterView<INewPackagePaymentView, NewPackagePaymentForm>()
                .RegisterService<IGetStartPackagesService, GetStartPackagesService>()
                .RegisterInstance<IBaseView>(this);

            SetProgressBar(0);

            controller.Run<NewPackagePresenter>();
        }

        public void LoadNewForm(IView newForm)
        {
            //this.panel_MainLoader.Controls.Clear();
            _currentForm = newForm as Form;
            _currentForm.Dock = DockStyle.Fill;
            _currentForm.TopLevel = false;
            _currentForm.TopMost = true;
            _currentForm.FormBorderStyle = FormBorderStyle.None;
            this.panel_Loader.Controls.Add(_currentForm);
            _currentForm.Show();
        }

        public void SetProgressBar(int step)
        {
            for (int i = 0; i < ProgressBar_tableLayoutPanel.ColumnCount; ++i)
            {
                Control control = ProgressBar_tableLayoutPanel.GetControlFromPosition(i, 0);
                int j = (int)Math.Round((double)(i + 1) / 2, MidpointRounding.AwayFromZero);

                switch (control)
                {
                    case Guna2CircleProgressBar circleProgressBar:
                    {
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

                        break;
                    }
                    case Guna2ProgressBar progressBar:
                    {
                        progressBar.Value = 0;

                        progressBar.FillColor = j >= step ? Color.FromArgb(200, 213, 218, 223) : Color.FromArgb(72, 180, 81);

                        break;
                    }
                }

            }
        }

    }
}
