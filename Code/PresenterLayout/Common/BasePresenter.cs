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
        protected IParentPresenter? ParentPresenter { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresenter(IApplicationController controller, TView view, IParentPresenter parentPresenter)
        {
            Controller = controller;
            View = view;
            ParentPresenter = parentPresenter;
        }

        protected BasePresenter(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public abstract void Run();
        /*public virtual void Run()
        {
            ParentPresenter.LoadNewForm(View);
        }*/
    }

    public abstract class BasePresenter<TView, TArg> : IPresenter<TArg>
        where TView : IView
    {
        protected TView View { get; private set; }
        protected IParentPresenter ParentPresenter { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresenter(IApplicationController controller, TView view, IParentPresenter parentPresenter)
        {
            Controller = controller;
            View = view;
            ParentPresenter = parentPresenter;
        }

        public abstract void Run(TArg argument);
    }
}
