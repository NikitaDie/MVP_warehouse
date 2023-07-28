using Forms;
using PresenterLayout.Common;
using PresenterLayout.Presenters;
using ServiceLayer.Services.Login;
using ViewLayout.Views;

namespace Main
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var presenter = new BaseFormPresenter(new BaseForm()); // Dependency Injection
            presenter.Run();

            /*var s = new BaseForm();
            Application.Run(s);*/

        }
    }
}