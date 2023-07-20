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
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    public class NewPackagePresenter : BasePresenter<INewPackageView>
    {
        private readonly IGetStartPackagesService _getStartPackagesService;
        private readonly ILoginService _makeUserPackageService;

        public NewPackagePresenter(IApplicationController controller, INewPackageView view, IBaseView baseView, IGetStartPackagesService getStartPackagesService) : base(controller, view, baseView)
        {
            _getStartPackagesService = getStartPackagesService;
        }

        public override void Run()
        {
            View.LoadStartPackages(GetStartPackages());
            BaseView.LoadNewForm(View);
        }

        private List<IPackageModel> GetStartPackages()
        {
            return _getStartPackagesService.GetStartPackages();
        }
    }
}
