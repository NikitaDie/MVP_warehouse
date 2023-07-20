using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayout.Models.Package
{
    public class Package : IPackageModel
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Size SizeDescription { get; set; }

        public Package(int price, string name, Size size)
        {
            Price = price;
            Name = name; 
            SizeDescription = size;
        }
    }
}
