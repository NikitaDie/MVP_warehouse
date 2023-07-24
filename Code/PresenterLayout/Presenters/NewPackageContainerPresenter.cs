using PresenterLayout.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewLayout.Views;

namespace PresenterLayout.Presenters
{
    public class NewPackageContainerPresenter : BasePresenter<INewPackageContainerView>
    {
        public NewPackageContainerPresenter(IApplicationController controller, INewPackageContainerView view, IBaseView baseView) : base(controller, view, baseView)
        {
        }


    }
}
