﻿using ModelLayout.Models.Package;
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

            View.NextPage += () => NextPage(View.GetSelectedPackage());
        }

        public override void Run()
        {
            View.LoadStartPackages(GetStartPackages());
            if (BaseView is INewPackageContainerView)
                (BaseView as INewPackageContainerView).SetProgressBar(1);
            BaseView.LoadNewForm(View);
        }

        private List<IPackageModel> GetStartPackages()
        {
            return _getStartPackagesService.GetStartPackages();
        }

        private void NextPage(IPackageModel package)
        {
            UserPackage userPackage = new UserPackage(package);
            Controller.Run<NewPackageUserDataPresenter, UserPackage>(userPackage);
            View.Close();
        }
    }
}
