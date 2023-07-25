using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayout.Views
{
    public interface INewPackageUserDataView : IView
    {
        public string RecipentName { get; set; }
        public string RecipentPostCode { get; set; }
        public string RecipentLocation { get; set; }
        public string RecipentStreet { get; set; }
        public string RecipentHouseNumber { get; set; }
        public string RecipentEmail { get; set; }
        public string SenderName { get; set; }
        public string SenderPostCode { get; set; }
        public string SenderLocation { get; set; }
        public string SenderStreet { get; set; }
        public string SenderHouseNumber { get; set; }
        public string SenderEmail { get; set; }

        public event Action NextPage;
    }
}
