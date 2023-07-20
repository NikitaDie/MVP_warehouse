using ModelLayout.Models.User;
using PresenterLayout.Common;
using ServiceLayer.Services.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    internal class MenuPresenter : BasePresenter<IMenuView, User>
    {
        //private readonly ILoginService _service;
        private readonly IBaseView _baseView;
        public MenuPresenter(IBaseView baseView, IApplicationController controller, IMenuView view) : base(controller, view, baseView)
        {
            View.BackToLoginPage += () => BackToLoginPage();
        }

        public override void Run(User user)
        {
            View.LoadUserSettings(user);
            BaseView.LoadNewForm(View);
        }

        private void BackToLoginPage()
        {
            Controller.Run<LoginPresenter>();
            View.Close();
        }

    }
}
