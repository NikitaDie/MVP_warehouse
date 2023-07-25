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
    public class NewPackagePaymentPresenter : BasePresenter<INewPackagePaymentView, UserPackage>
    {
        public NewPackagePaymentPresenter(IApplicationController controller, INewPackagePaymentView view, IBaseView baseView) : base(controller, view, baseView)
        {
        }

        public override void Run(UserPackage argument)
        {
            View.LoadPackageInfo(argument);
            if (BaseView is INewPackageContainerView view)
                view.SetProgressBar(3);
            BaseView.LoadNewForm(View);
        }
    }
}
