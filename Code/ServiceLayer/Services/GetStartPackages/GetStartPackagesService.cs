using ModelLayout.Models.Package;
using ModelLayout.Models.User;
using ServiceLayer.CommonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayout.Services.GetStartPackages
{
    public class GetStartPackagesService : IGetStartPackagesService
    {
        public DBDataSource DB { get; set; }

        public GetStartPackagesService()
        {
            string usersAutorizationConnection = "Host=warehouse-database.cessnsd4sw0t.eu-north-1.rds.amazonaws.com;Username=postgres;Password=Warehouse2048;Database=packages;";
            this.DB = new DBDataSource(usersAutorizationConnection);
        }
        public List<IPackageModel> GetStartPackages()
        {
            List<IPackageModel> packages = new List<IPackageModel>();

            try
            {
                var command = DB.dataSource.CreateCommand(
                    "Select name, price, size\r\n\t" +
                        "FROM start_packages");

                var reader = command.ExecuteReader();

                while (reader.Read())
                    Console.WriteLine(reader.GetString(0));                

            }
            catch (Exception) { return packages; }

            return packages;
        }
    }
}
