using ModelLayout.Common;
using ModelLayout.Models.Package;
using Newtonsoft.Json;
using ServiceLayer.CommonServices;

namespace ServiceLayout.Services.GetPackage
{
    public class GetPackageService : IGetPackageService
    {
        public DBDataSource DB { get; set; }

        public GetPackageService()
        {
            const string usersAutorizationConnection = "Host=warehouse-database.cessnsd4sw0t.eu-north-1.rds.amazonaws.com;Username=postgres;Password=Warehouse2048;Database=packages;";
            this.DB = new DBDataSource(usersAutorizationConnection);
        }
        public UserPackage GetPackage(string id)
        {
            UserPackage package;

            try
            {
                var command = DB.dataSource.CreateCommand(
                    "SELECT * FROM user_packages\r\n\t" +
                    $"WHERE id = {Int64.Parse(id)};");

                var reader = command.ExecuteReader();
                reader.Read();

                package = new UserPackage(reader.GetInt64(0).ToString(), Convert.ToDouble(reader.GetInt32(15) / 100), reader.GetString(1),
                    JsonConvert.DeserializeObject<Size>(reader.GetString(2)), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8),
                        reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14));

                if (package.ID == "0")
                    package.ID = "00000000000";
            }
            catch (Exception) { return new UserPackage(); }

            return package;
        }
    }
}
