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
    internal class NewPackageUserDataPresenter : BasePresenter<INewPackageUserDataView, UserPackage>
    {
        private UserPackage _userPackage;
        private readonly IGetHitsService _getHitsService;
        public NewPackageUserDataPresenter(IApplicationController controller, INewPackageUserDataView view, IBaseView baseView) : base(controller, view, baseView)
        {

            View.FindLocation += () => FindLocation();
            View.FindWarehouse += () => FindWarehouse();
        }

        public override void Run(UserPackage userPackage)
        {
            _userPackage = userPackage;
            if (BaseView is INewPackageContainerView)
                (BaseView as INewPackageContainerView).SetProgressBar(2);
            BaseView.LoadNewForm(View);
        }

        private void NextPage()
        {
            //_userPackage.Reciver = View.
           // Controller.Run<NewPackageUserDataPresenter, UserPackage>(userPackage);
            View.Close();
        }

        private void FindLocation()
        {
            if (View.Warehouse is not null)
                _getHitsService.FindLocationByWarehouse(View.Warehouse);
            else
                _getHitsService.FindLocation(View.TmpLocation);
        }

        private void FindWarehouse()
        {
            if (View.Location is not null)
                _getHitsService.FindWarehouseByLocation(View.Location);
            else
                _getHitsService.FindWarehouse(View.TmpWarehouse);
        }
    }
}
