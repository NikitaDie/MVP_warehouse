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
using ServiceLayout.Services.RegisterPackage;
using LightInject;

namespace PresenterLayout.Presenters
{
    public class NewPackageContainerPresenter : BasePresenter<INewPackageContainerView>, IParentPresenter
    {
        IApplicationController? _controller;
        private readonly IPackageService _packageService;
        public NewPackageContainerPresenter(IApplicationController controller, INewPackageContainerView view, IParentPresenter parentPresenter, IPackageService packageService) : base(controller, view, parentPresenter)
        {
            _packageService = packageService;
        }

        public override void Run()
        {
            NewPackage();
            ParentPresenter.LoadNewForm(View);
        }

        /*public void LoadPackage()
        {
            switch (View.CurrentForm) //
            {
                case INewPackageUserDataView:
                    _controller.Run<NewPackageUserDataPresenter, bool>(false);
                    break;
                case INewPackagePaymentView:
                    _controller.Run<NewPackagePaymentPresenter>();
                    break;
                case INewPackageFinalLabelView:
                    _controller.Run<NewPackageFinalLabelPresenter>();
                    break;
                default:
                    _controller.Run<NewPackagePresenter, bool>(false);
                    break;
            }
        }*/

        public void NewPackage()
        {
            //_controller?.Dispose(); //?

            if (_controller != null) // for what?, clean Userpackage?
            {
                _controller.Dispose();
            }

            SetProgressBar(0);
            _controller = GetController();
            _controller.Run<NewPackagePresenter, bool>(false/*, new PerContainerLifetime()*/);
        }

        private IApplicationController GetController()
        {
            var newId = _packageService.GetNewPackageID();
            var controller = new ApplicationController(new LightInjectAdapter())
                .RegisterView<INewPackageView, NewPackageForm>()
                .RegisterView<INewPackageUserDataView, NewPackageUserDataForm>()
                .RegisterView<INewPackagePaymentView, NewPackagePaymentForm>()
                .RegisterView<INewPackageFinalLabelView, NewPackageFinalLabelForm>()
                .RegisterService<IGetStartPackagesService, GetStartPackagesService>(new PerContainerLifetime()) //???
                .RegisterService<ILabelService, LabelService>(new PerContainerLifetime())
                .RegisterService<IPackageService, PackageService>(new PerContainerLifetime())
                .RegisterInstance<IParentPresenter>(this)
                .RegisterInstance<UserPackage>(new UserPackage(newId));

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
