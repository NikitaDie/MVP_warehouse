using ModelLayout.Models.Package;
using PresenterLayout.Common;
using ServiceLayout.Services.GetStartPackages;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    public class NewPackagePresenter : BasePresenter<INewPackageView, bool>
    {
        private readonly IGetStartPackagesService _getStartPackagesService;
        private readonly UserPackage _userPackage;
        private bool _changeCall;

        public NewPackagePresenter(IApplicationController controller, INewPackageView view,
            IGetStartPackagesService getStartPackagesService, IParentPresenter parentPresenter, UserPackage userPackage) : base(controller, view, parentPresenter)
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

            if (_userPackage != null)
            {
                View.SetCurrentOptionPanel(_userPackage.Name);
            }

            (ParentPresenter as NewPackageContainerPresenter)?.SetProgressBar(1);
            ParentPresenter.LoadNewForm(View);
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
            {
                //_userPackage = new UserPackage(package);
                //Controller.RegisterInstance<UserPackage>(new UserPackage(package));
                //Controller.Run<NewPackageUserDataPresenter, bool>(false);
            }

            View.Close();
        }

    }
}
