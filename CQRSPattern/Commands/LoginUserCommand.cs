namespace DesignPattern.CQRS.CQRSPattern.Commands
{
    public class LoginUserCommand
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginUserCommand(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
