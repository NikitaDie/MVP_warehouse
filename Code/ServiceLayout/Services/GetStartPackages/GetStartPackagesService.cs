using ModelLayout.Common;
using ModelLayout.Models.Package;
using ModelLayout.Models.User;
using Newtonsoft.Json;
using ServiceLayer.CommonServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ServiceLayout.Services.GetStartPackages
{
    public class GetStartPackagesService : IGetStartPackagesService
    {
        public DBDataSource DB { get; set; }

        public GetStartPackagesService()
        {
            const string usersAutorizationConnection = "server";
            this.DB = new DBDataSource(usersAutorizationConnection);
        }
        public List<IPackageModel> GetStartPackages()
        {
            List<IPackageModel> packages = new List<IPackageModel>();

            try
            {
                var command = DB.dataSource.CreateCommand(
                    "Select name, price, size\r\n\t" +
                        "FROM start_packages\r\n\t" +
                        "ORDER BY price;");

                var reader = command.ExecuteReader();

                while (reader.Read())
                    packages.Add(new Package(Convert.ToDouble(reader.GetInt32(1)) / 100, reader.GetString(0), JsonConvert.DeserializeObject<Size>(reader.GetString(2))));
        

            }
            catch (Exception) { return packages; }

            return packages;
        }
    }
}
