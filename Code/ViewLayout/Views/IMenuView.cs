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
        event Action BackToLoginPage;

        public void LoadUserSettings(IUserModel user);
    }
}
