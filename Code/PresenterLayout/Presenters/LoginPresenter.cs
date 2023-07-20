using Microsoft.AspNetCore.Mvc;
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
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        private readonly ILoginService _service;
        private readonly IBaseView _baseView;

        public LoginPresenter(IBaseView baseView, IApplicationController controller, ILoginView view, ILoginService service) : base(controller, view, baseView)
        {
            _service = service;
            _baseView = baseView;
            View.Login += () => Login(View.Username, View.Password);
        }

        private void Login(string username, string password)
        {
            if (username == null)
                throw new ArgumentNullException("username");
            if (password == null)
                throw new ArgumentNullException("password");
            // make sha
            var user = new User(username, password);
            if (!_service.Login(user))
            {
                View.ShowError("Invalid username or password");
            }
            else
            {
                //Controller.Run<MenuPresenter, User>(user);
                Controller.Run<MenuPresenter, User>(user);
                View.Close();
            }
        }
    }
}
