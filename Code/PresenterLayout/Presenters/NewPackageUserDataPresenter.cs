using ModelLayout.Models.Package;
using PresenterLayout.Common;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    internal class NewPackageUserDataPresenter : BasePresenter<INewPackageUserDataView, bool>
    {
        private readonly UserPackage _userPackage;
        private bool _changeCall;
        //private readonly IGetHitsService _getHitsService;
        public NewPackageUserDataPresenter(IApplicationController controller, INewPackageUserDataView view, IParentPresenter parentPresenter, UserPackage userPackage) : base(controller, view, parentPresenter)
        {
            _userPackage = userPackage;

            View.NextPage += NextPage;
        }

        public override void Run(bool changeCall)
        {
            _changeCall = changeCall;

            if (_changeCall) //make private method
            {
                View.RecipentName = _userPackage.RecipentName;
                View.RecipentPostCode = _userPackage.RecipentPostCode;
                View.RecipentLocation = _userPackage.RecipentLocation;
                View.RecipentStreet = _userPackage.RecipentStreet;
                View.RecipentHouseNumber = _userPackage.RecipentHouseNumber;
                View.RecipentEmail = _userPackage.RecipentEmail;
                View.SenderName = _userPackage.SenderName;
                View.SenderPostCode = _userPackage.SenderPostCode;
                View.SenderLocation = _userPackage.SenderLocation;
                View.SenderStreet = _userPackage.SenderStreet;
                View.SenderHouseNumber = _userPackage.SenderHouseNumber;
                View.SenderEmail = _userPackage.SenderEmail;
            }

            (ParentPresenter as NewPackageContainerPresenter)?.SetProgressBar(2);
            ParentPresenter.LoadNewForm(View);
        }

        private void NextPage()
        {
            _userPackage.RecipentName = View.RecipentName;
            _userPackage.RecipentPostCode = View.RecipentPostCode;
            _userPackage.RecipentLocation = View.RecipentLocation;
            _userPackage.RecipentStreet = View.RecipentStreet;
            _userPackage.RecipentHouseNumber = View.RecipentHouseNumber;
            _userPackage.RecipentEmail = View.RecipentEmail;
            _userPackage.SenderName = View.SenderName;
            _userPackage.SenderPostCode = View.SenderPostCode;
            _userPackage.SenderLocation = View.SenderLocation;
            _userPackage.SenderStreet = View.SenderStreet;
            _userPackage.SenderHouseNumber = View.SenderHouseNumber;
            _userPackage.SenderEmail = View.SenderEmail;

            Controller.Run<NewPackagePaymentPresenter>();
            View.Close();
        }
    }
}
