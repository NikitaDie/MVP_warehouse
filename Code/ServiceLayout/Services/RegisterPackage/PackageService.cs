using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayout.Models.Package;
using Newtonsoft.Json;
using ServiceLayer.CommonServices;
using SkiaSharp;

namespace ServiceLayout.Services.RegisterPackage
{
    public class PackageService : IPackageService
    {
        public DBDataSource DB { get; set; }

        public PackageService()
        {
            try
            {
                const string usersAutorizationConnection =
                    "Host=warehouse-database.cessnsd4sw0t.eu-north-1.rds.amazonaws.com;Username=postgres;Password=Warehouse2048;Database=packages;";
                DB = new DBDataSource(usersAutorizationConnection);
            } catch { }
        }

        public string GetNewPackageID()
        {
            var tmp = GetLastPackageId();
            ++tmp;
            return tmp.ToString();
        }

        private long GetLastPackageId()
        {
            var command = DB.dataSource.CreateCommand(@"SELECT MAX(""id"") FROM user_packages");

            var reader = command.ExecuteReader();
            reader.Read();

            return reader.GetInt64(0);
        }

        public bool RegisterPackage(UserPackage userPackage)
        {

            try
            {
                var command1 = DB.dataSource.CreateCommand(
                    "INSERT INTO user_packages (id, name, size, recipentname, recipentpostcode, recipentcity, recipentstreet, RecipentHouseNumber, recipentemail, " +
                    "SenderName, SenderPostCode, SenderCity, SenderStreet, SenderHouseNumber, SenderEmail, price)\r\n" +
                    "VALUES\r\n" +
                    $"(@id, @name, @size, @recipentname, @recipentpostcode, @recipentcity, @recipentstreet, @RecipentHouseNumber, @recipentemail, " +
                    "@SenderName, @SenderPostCode, @SenderCity, @SenderStreet, @SenderHouseNumber, @SenderEmail, @price)"
                );

                command1.Parameters.AddWithValue("id", long.Parse(userPackage.ID));
                command1.Parameters.AddWithValue("name", userPackage.Name);
                command1.Parameters.AddWithValue("size", JsonConvert.SerializeObject(userPackage.SizeDescription));
                command1.Parameters.AddWithValue("recipentname", userPackage.RecipentName);
                command1.Parameters.AddWithValue("recipentpostcode", userPackage.RecipentPostCode);
                command1.Parameters.AddWithValue("recipentcity", userPackage.RecipentLocation);
                command1.Parameters.AddWithValue("recipentstreet", userPackage.RecipentStreet);
                command1.Parameters.AddWithValue("RecipentHouseNumber", userPackage.RecipentHouseNumber);
                command1.Parameters.AddWithValue("recipentemail", userPackage.RecipentEmail);
                command1.Parameters.AddWithValue("SenderName", userPackage.SenderName);
                command1.Parameters.AddWithValue("SenderPostCode", userPackage.SenderPostCode);
                command1.Parameters.AddWithValue("SenderCity", userPackage.SenderLocation);
                command1.Parameters.AddWithValue("SenderStreet", userPackage.SenderStreet);
                command1.Parameters.AddWithValue("SenderHouseNumber", userPackage.SenderHouseNumber);
                command1.Parameters.AddWithValue("SenderEmail", userPackage.SenderEmail);
                command1.Parameters.AddWithValue("price", userPackage.Price);

                //{ JsonConvert.SerializeObject(userPackage.SizeDescription)}
                //var command2 = DB.dataSource.CreateCommand(
                //command.Parameters.AddWithValue("p", userPackage.ID);

                command1.ExecuteNonQuery();

            }
            catch { return false; }

            return true;
        }
    }
}
