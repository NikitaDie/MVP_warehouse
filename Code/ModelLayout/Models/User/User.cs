namespace ModelLayout.Models.User
{
    public class User : IUserModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; } = Roles.user;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

    public enum Roles
    {
        user,
        admin
    }
}