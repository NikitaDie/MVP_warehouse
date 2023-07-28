using Forms.MenuForms.NewPackage;
using ModelLayout.Models.Package;
using ModelLayout.Models.User;
using PresenterLayout.Common;
using ServiceLayer.Services.Login;
using ServiceLayout.Services.GetStartPackages;
using ServiceLayout.Services.Label;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayout;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    public class MenuPresenter : BasePresenter<IMenuView, IUserModel>, IParentPresenter
    {
        private readonly IApplicationController _controller;
        public MenuPresenter(IApplicationController controller, IMenuView view, IParentPresenter parentPresenter) : base(controller, view, parentPresenter)
        {
            _controller = GetController();
            View.BackToLoginPage += BackToLoginPage;
        }

        public override void Run(IUserModel user)
        {
            View.LoadUserSettings(user);
            ParentPresenter.LoadNewForm(View);

            _controller.Run<NewPackageContainerPresenter>();
        }

        private IApplicationController GetController()
        {
            var controller = new ApplicationController(new LightInjectAdapder())
                    .RegisterView<INewPackageContainerView, NewPackageContainerForm>()
                    .RegisterInstance<IParentPresenter>(this);

            return controller;
        }

        private void BackToLoginPage()
        {
            Controller.Run<LoginPresenter>();
            View.Close();
        }

        public void LoadNewForm(IView newForm)
        {
            View.LoadNewForm(newForm);
        }
    }
}
