using Microsoft.AspNetCore.Mvc;
using ModelLayout.Models.Package;
using PresenterLayout.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayout.Services.RegisterPackage;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    public class NewPackagePaymentPresenter : BasePresenter<INewPackagePaymentView>
    {
        private readonly UserPackage _userPackage;
        private readonly IPackageService _registerPackageService;
        public NewPackagePaymentPresenter(IApplicationController controller, INewPackagePaymentView view, IParentPresenter parentPresenter, IPackageService registerPackageService, UserPackage userPackage) : base(controller, view, parentPresenter)
        {
            _userPackage = userPackage;
            _registerPackageService = registerPackageService;

            View.Pay += PayAndGoForward;
            View.ReturnToNewPackagePage += ReturnToNewPackagePage;
            View.ReturnToNewPackageUserDataPage += ReturnToNewPackageUserDataPage;
        }

        public override void Run()
        {
            View.LoadPackageInfo(_userPackage);

            (ParentPresenter as NewPackageContainerPresenter)?.SetProgressBar(3);
            ParentPresenter.LoadNewForm(View);
        }

        private void PayAndGoForward()
        {
            //if (Pay())
            _registerPackageService.RegisterPackage(_userPackage);
            Controller.Run<NewPackageFinalLabelPresenter>();
            View.Close();
        }

        private void ReturnToNewPackagePage()
        {
           
            //btnNextPage.Text = changeCall ? "Return to Payment" : "Continue to address input";
            Controller.GetInstance<NewPackagePresenter>().Run(true);
            //Controller.Run<NewPackagePresenter, bool>(true);
            View.Close();
        }

        private void ReturnToNewPackageUserDataPage()
        {

            //btnNextPage.Text = changeCall ? "Return to Payment" : "Continue to address input";
            Controller.GetInstance<NewPackageUserDataPresenter>().Run(true);
            View.Close();
        }
    }
}
