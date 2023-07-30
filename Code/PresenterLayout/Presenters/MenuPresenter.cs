using ModelLayout.Models.User;
using PresenterLayout.Common;
using Forms.MenuForms.NewPackage;
using ViewLayout;
using ViewLayout.Views;
using Forms.MenuForms;

namespace PresenterLayout.Presenters
{
    public class MenuPresenter : BasePresenter<IMenuView, IUserModel>, IParentPresenter
    {
        private readonly IApplicationController _controller;
        public MenuPresenter(IApplicationController controller, IMenuView view, IParentPresenter parentPresenter) : base(controller, view, parentPresenter)
        {
            _controller = GetController();
            View.BackToLoginPage += BackToLoginPage;

            View.LaunchNewPackage += () =>
            {
                if (View.CurrentForm is INewPackageContainerView) return;

                View.CurrentForm?.Close();
                _controller.Run<NewPackageContainerPresenter>();
            };

            View.LaunchSearchPackage += () =>
            {
                if (View.CurrentForm is ISearchPackageView) return;

                View.CurrentForm?.Close();
                _controller.Run<SearchPackagePresenter>();
            };
        }

        public override void Run(IUserModel user)
        {
            View.LoadUserSettings(user);
            ParentPresenter.LoadNewForm(View);
        }

        private IApplicationController GetController()
        {
           var controller = new ApplicationController(new LightInjectAdapder())
                    .RegisterView<INewPackageContainerView, NewPackageContainerForm>()
                    .RegisterView<ISearchPackageView, SearchPackageForm>()
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
