namespace SpaDay6.Models
{
    public class User
    {
        public string Useranme { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string VerifyPassword { get; set; }

        public User(string useranme, string email, string password, string verifyPassword)
        {
            Useranme = useranme;
            Email = email;
            Password = password;
            VerifyPassword = verifyPassword;
        }
    }
}
