using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayout.Views
{
    public interface INewPackageContainerView : IBaseView
    {
        IView CurrentForm { get; protected set; }
        public void SetProgressBar(int step);
    }
}
