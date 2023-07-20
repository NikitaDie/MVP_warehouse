using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayout.Views
{
    public interface ILoginView : IView
    {
        string Username { get; }
        string Password { get; }

        event Action Login;
        void ShowError(string errorMessage);
    }
}
