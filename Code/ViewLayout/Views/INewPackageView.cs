using ModelLayout.Models.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayout.Views
{
    public interface INewPackageView : IView
    {
        public void LoadStartPackages(List<IPackageModel> packages);

    }
}
