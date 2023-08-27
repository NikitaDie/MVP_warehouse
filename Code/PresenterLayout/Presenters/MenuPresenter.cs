using ModelLayout.Models.User;
using PresenterLayout.Common;
using Forms.MenuForms.NewPackage;
using ViewLayout;
using ViewLayout.Views;
using Forms.MenuForms;
using Forms.MenuForms.Common;
using LightInject;
using ServiceLayout.Services.GetPackage;
using ServiceLayout.Services.RegisterPackage;
using ServiceLayout.Services.SuggestionService;
using ServiceLayout.Services.Label;

namespace PresenterLayout.Presenters
{
    public class MenuPresenter : BasePresenter<IMenuView, IUserModel>, IParentPresenter
    {
        private readonly IApplicationController _controller;
        //private IParentPresenter _lastInternalPresenter; //???
        public MenuPresenter(IApplicationController controller, IMenuView view, IParentPresenter parentPresenter) : base(controller, view, parentPresenter)
        {
            _controller = GetController();
            View.BackToLoginPage += BackToLoginPage;

            View.LaunchNewPackage += () =>
            {
                if (View.CurrentForm is INewPackageContainerView) return;

                View.CurrentForm?.Close();

                _controller.Run<NewPackageContainerPresenter>(/*new PerContainerLifetime()*/);
                //_controller.GetInstance<NewPackageContainerPresenter>().CloseAllForms ?
                /*try
                {
                    _controller.GetInstance<NewPackageContainerPresenter>().Run();
                }
                catch
                {
                    _controller.Run<NewPackageContainerPresenter>(); //get or dispose then
                }*/

            };

            View.LaunchSearchPackage += () =>
            {
                if (View.CurrentForm is ISearchPackageView) return;

                View.CurrentForm?.Close();
                _controller.Run<SearchPackagePresenter>(/*new PerContainerLifetime()*/);
            };
        }

        public override void Run(IUserModel user)
        {
            View.LoadUserSettings(user);
            ParentPresenter.LoadNewForm(View);
            _controller.Run<NewPackageContainerPresenter>(/*new PerContainerLifetime()*/);
        }

        private IApplicationController GetController()
        {
           var controller = new ApplicationController(new LightInjectAdapter())
                    .RegisterView<INewPackageContainerView, NewPackageContainerForm>()
                    .RegisterView<ISearchPackageView, SearchPackageForm>()
                    .RegisterService<ILabelService, LabelService>()
                    .RegisterService<IPackageService, PackageService>()
                    .RegisterService<IGetPackageService, GetPackageService>()
                    .RegisterService<ISuggestionService, SuggestionService>()
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
