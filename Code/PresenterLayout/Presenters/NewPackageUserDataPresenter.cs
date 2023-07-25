using ModelLayout.Models.Package;
using PresenterLayout.Common;
using ServiceLayout.Services.GetAdressHitsService;
using ServiceLayout.Services.GetStartPackages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    internal class NewPackageUserDataPresenter : BasePresenter<INewPackageUserDataView>
    {
        private readonly UserPackage _userPackage;
        //private readonly IGetHitsService _getHitsService;
        public NewPackageUserDataPresenter(IApplicationController controller, INewPackageUserDataView view, IBaseView baseView, UserPackage userPackage) : base(controller, view, baseView)
        {
            _userPackage = userPackage;
            View.NextPage += NextPage;
        }

        public override void Run()
        {
            if (BaseView is INewPackageContainerView view)
                view.SetProgressBar(2);
            BaseView.LoadNewForm(View);
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
