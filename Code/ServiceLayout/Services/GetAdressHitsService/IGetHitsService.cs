using ServiceLayout.CommonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayout.Services.GetAdressHitsService
{
    public interface IGetHitsService : IDBService
    {
        public string FindLocation(string location);
        public string FindLocationByWarehouse(string warehouse);
        public string FindWarehouse(string warehouse);
        public string FindWarehouseByLocation(string location);
    }
}
