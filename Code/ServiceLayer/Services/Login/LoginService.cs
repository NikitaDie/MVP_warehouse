using ModelLayout.Models.User;
using ServiceLayer.CommonServices;

namespace ServiceLayer.Services.Login
{
    public class LoginService : ILoginService
    {
        public DBDataSource DB { get; set; }
        public LoginService()
        {
            string usersAutorizationConnection = "Host=warehouse-database.cessnsd4sw0t.eu-north-1.rds.amazonaws.com;Username=postgres;Password=Warehouse2048;Database=users;";
            this.DB = new DBDataSource(usersAutorizationConnection);
        }

        public bool Login(User user)
        {

            try
            {
                var command = DB.dataSource.CreateCommand(
                    "Select password, name, role, warehouseid\r\n\t" +
                        "FROM users_authorization\r\n\t" +
                            "INNER JOIN users_information\r\n\t\t" +
                                "ON users_authorization.id = users_information.id\r\n\t" +
                            "INNER JOIN users_roles\r\n\t\t" +
                                "ON users_roles.id = users_information.id\r\n\t" +
                        $"WHERE login = '{user.Username}'"); //29-30 other ex?

                var reader = command.ExecuteReader();
                reader.Read();

                if (BCrypt.Net.BCrypt.Verify(user.Password, reader.GetString(0)))
                {
                    try
                    {
                        user.Name = reader.GetString(1);
                    }
                    catch (Exception) { return false; } //maybe some notification for admin?

                    try
                    {
                        string strRole = reader.GetString(2);

                        if (strRole == "admin")
                            user.Role = Roles.admin;
                        else
                            user.Role = Roles.user;
                    }
                    catch (Exception) { user.Role = Roles.user; }

                    try
                    {
                        user.Id = reader.GetString(3);
                    }
                    catch (Exception) { return false; }

                    return true;
                }

            }
            catch (Exception) { return false; }

            return false;
        }
    }
}
