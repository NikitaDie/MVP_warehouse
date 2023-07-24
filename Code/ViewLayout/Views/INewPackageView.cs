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
        /*IControl? lastBackOptionPanel;
        public Dictionary<IControl, IPackageModel> PanelsToPackages { get; set; }*/
        event Action NextPage;
        public IPackageModel GetSelectedPackage();
        public void LoadStartPackages(List<IPackageModel> packages);

    }
}
