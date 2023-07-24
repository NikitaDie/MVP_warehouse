using ServiceLayer.CommonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayout.Services.GetAdressHitsService
{
    public class GetHitsService : IGetHitsService
    {
        public DBDataSource DB { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string FindLocation(string location)
        {
            throw new NotImplementedException();
        }

        public string FindLocationByWarehouse(string warehouse)
        {
            throw new NotImplementedException();
        }

        public string FindWarehouse(string warehouse)
        {
            throw new NotImplementedException();
        }

        public string FindWarehouseByLocation(string location)
        {
            throw new NotImplementedException();
        }
    }
}
