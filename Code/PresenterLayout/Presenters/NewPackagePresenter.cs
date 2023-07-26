using ModelLayout.Models.Package;
using ModelLayout.Models.User;
using PresenterLayout.Common;
using ServiceLayer.Services.Login;
using ServiceLayout.Services.GetStartPackages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    public class NewPackagePresenter : BasePresenter<INewPackageView, bool>
    {
        //private UserPackage _userPackage; ?
        private readonly IGetStartPackagesService _getStartPackagesService;
        //private readonly ILoginService _makeUserPackageService;
        private UserPackage _userPackage;
        private bool _changeCall;

        public NewPackagePresenter(IApplicationController controller, INewPackageView view, IBaseView baseView,
            IGetStartPackagesService getStartPackagesService, UserPackage userPackage) : base(controller, view, baseView)
        {
            _userPackage = userPackage;
            _getStartPackagesService = getStartPackagesService;

            View.NextPage += () => NextPage(View.GetSelectedPackage());
        }

        public override void Run(bool changeCall)
        {
            _changeCall = changeCall;
            View.PagesButtonText = _changeCall ? "Return to Payment" : "Continue to address input";
            View.LoadStartPackages(GetStartPackages());

            if (_userPackage.Name != null)
            {
                View.SetCurrentOptionPanel(_userPackage.Name);
            }

            if (BaseView is INewPackageContainerView view)
                view.SetProgressBar(1);
            BaseView.LoadNewForm(View);
        }

        private List<IPackageModel> GetStartPackages()
        {
            return _getStartPackagesService.GetStartPackages();
        }

        private void NextPage(IPackageModel package)
        {
            _userPackage.Price = package.Price;
            _userPackage.Name = package.Name;
            _userPackage.SizeDescription = package.SizeDescription;

            if (_changeCall)
                Controller.Run<NewPackagePaymentPresenter>();
            else
                Controller.Run<NewPackageUserDataPresenter, bool>(false);

            View.Close();
        }

    }
}
