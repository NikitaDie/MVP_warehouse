using ModelLayout.Models.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayout.CommonServices;

namespace ServiceLayout.Services.RegisterPackage
{
    public interface IPackageService : IDbService
    {
        public string GetNewPackageID();
        public bool RegisterPackage(UserPackage userPackage);
    }
}
