using BalanceSheetsApp.Web.Interfaces;
using BalanceSheetsApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BalanceSheetsApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IImportViewModelService importService;
        private readonly IExportViewModelService exportService;

        public HomeController(ILogger<HomeController> logger, IImportViewModelService importService, IExportViewModelService exportService)
        {
            this.importService = importService;
            _logger = logger;
            this.exportService = exportService;
        }

        public async Task<IActionResult> Index()
        {
            return View(new BankSelectorViewModel() { BankViewModels = await this.exportService.ExportBanks() });
        }

        [HttpGet]
        public async Task<IActionResult> Import()
        {
            return View();
        }

        public async Task<IActionResult> ImportExcel(ImportViewModel model)
        {
            await importService.Parse(model);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}