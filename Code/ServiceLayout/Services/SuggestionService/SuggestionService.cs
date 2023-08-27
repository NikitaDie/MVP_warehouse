using ModelLayout.Models.Package;
using Newtonsoft.Json;
using ServiceLayer.CommonServices;
using ServiceLayout.Services.GetPackage;

namespace ServiceLayout.Services.SuggestionService
{
    public class SuggestionService : ISuggestionService
    {
        public DBDataSource DB { get; set; }

        public SuggestionService()
        {
            const string usersAutorizationConnection = "Host=warehouse-database.cessnsd4sw0t.eu-north-1.rds.amazonaws.com;Username=postgres;Password=Warehouse2048;Database=packages;";
            this.DB = new DBDataSource(usersAutorizationConnection);
        }
        public List<string> GetIds(string id)
        {
            List<string> ids = new List<string>();

            while (id.Length != 4)
                id = id + "_";

            try
            {
                var command = DB.dataSource.CreateCommand(
                    "SELECT id FROM user_packages\r\n\t" +
                    $"WHERE id::text LIKE '%{id}%'");

                var reader = command.ExecuteReader();

                while (reader.Read())
                    ids.Add(reader.GetInt64(0).ToString());


            }
            catch (Exception) { return ids; }

            return ids;
        }
    }
}
