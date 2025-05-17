using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.CQRSPattern.Handlers;
using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers
{
    public class MusteriController : Controller
    {
        private readonly CreateMusteriCommandHandler _createMusteriCommandHandler;
        private readonly ErrorLogService _errorLogService;
        private readonly GetMusteriQueryHandler _getMusteriQueryHandler;

        // İleride ekleyeceğin sorgu ve güncelleme handler'ları için hazırlık
        // private readonly DeleteMusteriCommandHandler _deleteMusteriCommandHandler;
        // private readonly GetMusteriByIDQueryHandler _getMusteriByIDQueryHandler;
        // private readonly UpdateMusteriCommandHandler _updateMusteriCommandHandler;

        public MusteriController(
            CreateMusteriCommandHandler createMusteriCommandHandler,
            ErrorLogService errorLogService,
            GetMusteriQueryHandler getMusteriQueryHandler
        )
        {
            _createMusteriCommandHandler = createMusteriCommandHandler;
            _errorLogService = errorLogService;
            _getMusteriQueryHandler = getMusteriQueryHandler;
        }

        public IActionResult Index()
        {
            var musteriler = _getMusteriQueryHandler.Handle();
            return View(musteriler);
        }

        [HttpGet]
        public IActionResult AddMusteri()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMusteri(CreateMusteriCommand command)
        {
            try
            {
                _createMusteriCommandHandler.Handle(command);
                return RedirectToAction("Index", "Musteri"); // ya da Musteri listesi varsa oraya yönlendirme
            }
            catch (Exception ex)
            {
                _errorLogService.LogError(ex.Message, "MusteriController", "AddMusteri");
                return View("Error");
            }
        }
       
    }
}
