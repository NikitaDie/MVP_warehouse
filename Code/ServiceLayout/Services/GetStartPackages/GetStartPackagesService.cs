﻿using ModelLayout.Common;
using ModelLayout.Models.Package;
using Newtonsoft.Json;
using ServiceLayer.CommonServices;

namespace ServiceLayout.Services.GetStartPackages
{
    public class GetStartPackagesService : IGetStartPackagesService
    {
        public DBDataSource DB { get; set; }

        public GetStartPackagesService()
        {
            const string usersAutorizationConnection = "Host=warehouse-database.cessnsd4sw0t.eu-north-1.rds.amazonaws.com;Username=postgres;Password=Warehouse2048;Database=packages;";
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
