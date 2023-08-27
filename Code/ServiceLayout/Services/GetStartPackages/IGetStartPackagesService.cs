using ModelLayout.Models.Package;
using ServiceLayer.CommonServices;
using ServiceLayout.CommonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayout.Services.GetStartPackages
{
    public interface IGetStartPackagesService : IDbService
    {
        public List<IPackageModel> GetStartPackages();
    }
}
