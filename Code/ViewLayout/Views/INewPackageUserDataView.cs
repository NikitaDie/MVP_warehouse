using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayout.Views
{
    public interface INewPackageUserDataView : IView
    {
        public string RecipentName { get; }
        public string RecipentPostCode { get; }
        public string RecipentLocation { get; }
        public string RecipentStreet { get; }
        public string RecipentHouseNumber { get; }
        public string RecipentEmail { get; }
        public string SenderName { get; }
        public string SenderPostCode { get; }
        public string SenderLocation { get; }
        public string SenderStreet { get; }
        public string SenderHouseNumber { get; }
        public string SenderEmail { get; }

        public event Action NextPage;
    }
}
