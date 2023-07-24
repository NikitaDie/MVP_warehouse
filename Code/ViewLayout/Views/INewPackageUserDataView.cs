using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayout.Views
{
    public interface INewPackageUserDataView : IView
    {
        public string Location { get; set; }
        public string Warehouse { get; set; }
        public string TmpLocation { get; set; }
        public string TmpWarehouse { get; set; }

        public event Action FindLocation;
        public event Action FindWarehouse;
    }
}
