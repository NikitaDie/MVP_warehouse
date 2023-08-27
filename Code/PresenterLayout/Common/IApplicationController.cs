using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayout;

namespace PresenterLayout.Common
{
    public interface IApplicationController
    {
        IApplicationController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IView;

        IApplicationController RegisterInstance<TArgument>(TArgument instance);

        IApplicationController RegisterService<TService, TImplementation>()
            where TImplementation : class, TService;

        IApplicationController RegisterService<TService, TImplementation>(ILifetime lifetime)
            where TImplementation : class, TService;

        void Dispose();

        T GetInstance<T>();


        void Run<TPresenter>()
            where TPresenter : class, IPresenter;

        void Run<TPresenter>(ILifetime lifetime)
            where TPresenter : class, IPresenter;

        void Run<TPresenter, TArgumnent>(TArgumnent argumnent)
            where TPresenter : class, IPresenter<TArgumnent>;

        public void Run<TPresenter, TArgument>(TArgument argument, ILifetime lifetime)
            where TPresenter : class, IPresenter<TArgument>;
    }
}
