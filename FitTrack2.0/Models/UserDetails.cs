namespace FitTrack2._0.Models
{
    public class UserDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserDetails() { }

        public UserDetails(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
