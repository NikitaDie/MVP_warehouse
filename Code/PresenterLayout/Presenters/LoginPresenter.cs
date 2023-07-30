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

        public LoginPresenter(IApplicationController controller, ILoginView view, ILoginService service, IParentPresenter parentPresenter) : base(controller, view, parentPresenter)
        {
            _service = service;
            View.Login += () => Login(View.Username, View.Password);
        }

        public override void Run()
        {
            ParentPresenter?.LoadNewForm(View);
        }

        private void Login(string username, string password)
        {
            if (username == null)
                throw new ArgumentNullException(nameof(username));
            if (password == null)
                throw new ArgumentNullException(nameof(password));
            // make sha
            var user = new User(username, password);
            if (!_service.Login(user))
            {
                View.ShowError("Invalid username or password");
            }
            else
            {
                View.Close();
                Controller.Run<MenuPresenter, User>(user);
            }
        }

    }
}
