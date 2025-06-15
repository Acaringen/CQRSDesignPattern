namespace DesignPattern.CQRS.CQRSPattern.Results
{
    public class LoginUserResult
    {
        public bool IsSuccess { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
    }
}
