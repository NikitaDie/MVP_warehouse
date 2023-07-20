using ModelLayout.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayout.Models.Package
{
    public interface IPackageModel
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public Size SizeDescription { get; set; }
        
    }
}
