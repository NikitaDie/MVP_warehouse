using Forms.MenuForms.Common;
using LightInject;
using ModelLayout.Models.Package;
using PresenterLayout.Common;
using ServiceLayout.Services.Label;
using ViewLayout;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    public class NewPackageFinalLabelPresenter : BasePresenter<INewPackageFinalLabelView>, IParentPresenter
    {
        private readonly IApplicationController _parentController;
        private readonly IApplicationController _controller;
        private readonly UserPackage _userPackage;
        public NewPackageFinalLabelPresenter(IApplicationController controller, INewPackageFinalLabelView view, IParentPresenter parentPresenter, ILabelService labelService, UserPackage userPackage) : base(controller, view, parentPresenter)
        {
            _parentController = controller;
            _controller = GetController();
            _userPackage = userPackage;

            View.NewPackage += NewPackage;
        }

        public override void Run()
        {
            _controller.Run<LabelPresenter, ILabelService>(_parentController.GetInstance<ILabelService>(), new PerContainerLifetime());

            (ParentPresenter as NewPackageContainerPresenter)?.SetProgressBar(4);
            LoadLable();
            ParentPresenter.LoadNewForm(View);
        }

        private IApplicationController GetController()
        {
            var controller = new ApplicationController(new LightInjectAdapter())
                .RegisterView<ILabelView, PackageLabel>()
                .RegisterInstance<IParentPresenter>(this);

            return controller;
        }

        public void LoadNewForm(IView newForm)
        {
            View.LoadNewForm(newForm);
        }

        public void LoadLable()
        {
            _controller.GetInstance<LabelPresenter>().LoadData(_userPackage);
        }

        private void NewPackage()
        {
            View.Close();
            (ParentPresenter as NewPackageContainerPresenter)?.NewPackage();
        }
    }
}
