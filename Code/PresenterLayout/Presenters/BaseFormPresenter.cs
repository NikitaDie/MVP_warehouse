using ModelLayout.Models.User;
using PresenterLayout.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms;
using ServiceLayer.Services.Login;
using ViewLayout;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    public class BaseFormPresenter : IParentPresenter
    {
        private readonly IApplicationController _controller;
        private readonly IBaseView _view;
        public BaseFormPresenter(IBaseView view)
        {
            _view = view;
            _controller = GetController();
        }

        public void Run()
        {
            _controller.Run<LoginPresenter>();
            _view.Show();
        }
        private IApplicationController GetController()
        {
            var controller = new ApplicationController(new LightInjectAdapder())
                .RegisterView<ILoginView, LoginForm>()
                .RegisterView<IMenuView, MenuForm>()
                .RegisterService<ILoginService, LoginService>()
                .RegisterInstance<IParentPresenter>(this);

            return controller;
        }

        public void LoadNewForm(IView newForm)
        {
            _view.LoadNewForm(newForm);
        }
    }
}
