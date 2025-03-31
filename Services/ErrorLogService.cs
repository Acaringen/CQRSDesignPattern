using System;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.Services
{
    public class ErrorLogService
    {
        private readonly Context _context;

        public ErrorLogService(Context context)
        {
            _context = context;
        }

        public void LogError(string errorMessage, string controller, string action)
        {
            var error = new ErrorLog
            {
                ErrorMessage = errorMessage,
                ControllerName = controller,
                ActionName = action,
                ErrorDate = DateTime.Now
            };

            _context.ErrorLogs.Add(error);
            _context.SaveChanges();
        }
    }
}
