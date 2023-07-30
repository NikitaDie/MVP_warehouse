using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayout.Models.User;

namespace ViewLayout.Views
{
    public interface IMenuView : IBaseView
    {
        IView CurrentForm { get; protected set; }
        event Action BackToLoginPage;
        event Action LaunchNewPackage;
        event Action LaunchSearchPackage;

        public void LoadUserSettings(IUserModel user);
    }
}
