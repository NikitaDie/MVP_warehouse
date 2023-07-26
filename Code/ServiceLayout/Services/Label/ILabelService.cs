using ModelLayout.Models.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayout.Services.Label
{
    public interface ILabelService
    {
        public string GetBarcode(string label);
    }
}
