using PresenterLayout.Common;
using PresenterLayout.Presenters;
using ViewLayout.Views;

namespace Forms
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
            var s = new BaseForm();
            Application.Run(s);

        }
    }
}