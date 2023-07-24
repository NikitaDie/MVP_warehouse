using ModelLayout.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayout.Models.Package
{
    public class Package : IPackageModel
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public Size SizeDescription { get; set; }

        public Package(double price, string name, Size size)
        {
            Price = price;
            Name = name; 
            SizeDescription = size;
        }
        

    }
}
