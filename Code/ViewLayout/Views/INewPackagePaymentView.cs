using ModelLayout.Models.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayout.Views
{
    public interface INewPackagePaymentView : IView
    {
        event Action Pay;
        event Action ReturnToNewPackagePage;
        event Action ReturnToNewPackageUserDataPage;

        public void LoadPackageInfo(UserPackage package);
    }
}
