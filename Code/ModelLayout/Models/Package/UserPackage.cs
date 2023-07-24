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
        public string Reciver { set; get; }
        public string Sender { set; get; }
        public string CurrentWarehouseID { set; get; }
        public string FinalWarehouseID { set; get; }

        public UserPackage(IPackageModel packageBase)
        {
            Price = packageBase.Price;
            Name = packageBase.Name;
            SizeDescription = packageBase.SizeDescription;
        }
    }
}
