using ModelLayout.Models.Package;
using PresenterLayout.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    public class NewPackagePaymentPresenter : BasePresenter<INewPackagePaymentView>
    {
        private readonly UserPackage _userPackage;
        public NewPackagePaymentPresenter(IApplicationController controller, INewPackagePaymentView view, IBaseView baseView, UserPackage userPackage) : base(controller, view, baseView)
        {
            _userPackage = userPackage;
            View.ReturnToNewPackagePage += ReturnToNewPackagePage;
        }

        public override void Run()
        {
            View.LoadPackageInfo(_userPackage);
            if (BaseView is INewPackageContainerView view)
                view.SetProgressBar(3);
            BaseView.LoadNewForm(View);
        }

        private void ReturnToNewPackagePage()
        {
           
            //btnNextPage.Text = changeCall ? "Return to Payment" : "Continue to address input";
            Controller.Run<NewPackagePresenter, bool>(true);
            View.Close();
        }
    }
}
