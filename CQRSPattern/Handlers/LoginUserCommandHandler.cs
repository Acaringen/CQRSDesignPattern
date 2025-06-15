using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class LoginUserCommandHandler
    {
        private readonly Context _context;
        public LoginUserCommandHandler()
        {
            _context = new Context(); 
        }
        public LoginUserResult Handle(LoginUserCommand command)
        {
            var user = _context.Kullanicilar
                .FirstOrDefault(x => x.KullaniciAdi == command.Username && x.Sifre == command.Password);

            if (user != null)
            {
                return new LoginUserResult
                {
                    IsSuccess = true,
                    Username = user.KullaniciAdi,
                    Message = "Giriş başarılı"
                };
            }

            // ❌ Başarısız giriş denemesi için log kaydı
            _context.ErrorLogs.Add(new ErrorLog
            {
                ErrorMessage = $"Hatalı giriş denemesi - Kullanıcı adı: {command.Username}",
                ControllerName = "Home",
                ActionName = "Login",
                ErrorDate = DateTime.Now
            });

            _context.SaveChanges();

            return new LoginUserResult
            {
                IsSuccess = false,
                Message = "Kullanıcı adı veya şifre hatalı"
            };
        }

    }
}
