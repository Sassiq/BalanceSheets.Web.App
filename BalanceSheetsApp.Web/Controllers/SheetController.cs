using BalanceSheetsApp.Web.Interfaces;
using BalanceSheetsApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BalanceSheetsApp.Web.Controllers
{
    public class SheetController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExportViewModelService service;

        public SheetController(ILogger<HomeController> logger, IExportViewModelService service)
        {
            _logger = logger;
            this.service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ShowSheet(int id)
        {
            return View(await this.service.ExportBank(id));
        }
    }
}
