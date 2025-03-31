using DesignPattern.CQRS.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ErrorLogService _errorLogService;

        public ErrorController(ErrorLogService errorLogService)
        {
            _errorLogService = errorLogService;
        }

        [HttpPost]
        public IActionResult LogClientError([FromBody] ClientErrorModel model)
        {
            if (model == null || string.IsNullOrWhiteSpace(model.ErrorMessage))
            {
                return BadRequest("Geçersiz hata mesajı.");
            }

            _errorLogService.LogError(model.ErrorMessage, "Client", "JavaScript");
            return Ok("Hata kaydedildi.");
        }
    }

    public class ClientErrorModel
    {
        public string ErrorMessage { get; set; }
    }
}
