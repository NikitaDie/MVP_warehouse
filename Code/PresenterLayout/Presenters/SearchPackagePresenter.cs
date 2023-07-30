using PresenterLayout.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    public class SearchPackagePresenter : BasePresenter<ISearchPackageView>
    {
        public SearchPackagePresenter(IApplicationController controller, ISearchPackageView view, IParentPresenter parentPresenter) : base(controller, view, parentPresenter)
        {
        }

        public override void Run()
        {
            ParentPresenter.LoadNewForm(View);
        }
    }
}
