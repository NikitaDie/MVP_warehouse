using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayout;
using ViewLayout.Views;

namespace PresenterLayout.Common
{
    public abstract class BasePresenter<TView> : IPresenter
        where TView : IView
    {
        protected TView View { get; private set; }
        protected IBaseView BaseView { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresenter(IApplicationController controller, TView view, IBaseView baseView)
        {
            Controller = controller;
            View = view;
            BaseView = baseView;
        }

        public virtual void Run()
        {
            BaseView.LoadNewForm(View);
        }
    }

    public abstract class BasePresenter<TView, TArg> : IPresenter<TArg>
        where TView : IView
    {
        protected TView View { get; private set; }
        protected IBaseView BaseView { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresenter(IApplicationController controller, TView view, IBaseView baseView)
        {
            Controller = controller;
            View = view;
            BaseView = baseView;
        }

        public abstract void Run(TArg argument);
    }
}
