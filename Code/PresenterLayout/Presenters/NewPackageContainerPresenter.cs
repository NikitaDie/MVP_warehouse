using ModelLayout.Models.Package;
using PresenterLayout.Common;
using ServiceLayout.Services.GetStartPackages;
using ServiceLayout.Services.Label;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms.MenuForms.NewPackage;
using ViewLayout;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    public class NewPackageContainerPresenter : BasePresenter<INewPackageContainerView>, IParentPresenter
    {
        IApplicationController? _controller;
        public NewPackageContainerPresenter(IApplicationController controller, INewPackageContainerView view, IParentPresenter parentPresenter) : base(controller, view, parentPresenter)
        {

        }

        public override void Run()
        {
            NewPackage();
            ParentPresenter.LoadNewForm(View);
        }

        public void NewPackage()
        {
            SetProgressBar(0);
            _controller = getController();
            _controller.Run<NewPackagePresenter, bool>(false);
        }

        private IApplicationController getController()
        {
            var controller = new ApplicationController(new LightInjectAdapder())
                .RegisterView<INewPackageView, NewPackageForm>()
                .RegisterView<INewPackageUserDataView, NewPackageUserDataForm>()
                .RegisterView<INewPackagePaymentView, NewPackagePaymentForm>()
                .RegisterView<INewPackageFinalLabelView, NewPackageFinalLabelForm>()
                .RegisterService<IGetStartPackagesService, GetStartPackagesService>()
                .RegisterService<ILabelService, LabelService>()
                .RegisterInstance<IParentPresenter>(this)
                .RegisterInstance<UserPackage>(new UserPackage("134768948102")); //service for generating ID

            return controller;
        }

        public void SetProgressBar(int value)
        {
            View.SetProgressBar(value);
        }

        public void LoadNewForm(IView newForm)
        {
            View.LoadNewForm(newForm);
        }


    }
}
