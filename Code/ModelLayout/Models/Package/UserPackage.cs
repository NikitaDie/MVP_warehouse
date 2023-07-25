using ModelLayout.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayout.Models.Package
{
    public class UserPackage //: IPackageModel
    {
        public double Price { get; }
        public string Name { get; }
        public Size SizeDescription { get; }


        public uint ID { get; }
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
        public string CurrentWarehouseID { set; get; }

        public UserPackage(IPackageModel packageBase)
        {
            Price = packageBase.Price;
            Name = packageBase.Name;
            SizeDescription = packageBase.SizeDescription;
        }
    }
}
