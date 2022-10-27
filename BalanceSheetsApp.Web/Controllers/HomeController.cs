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

        public HomeController(ILogger<HomeController> logger, IImportViewModelService importService)
        {
            this.importService = importService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Import(ImportViewModel model)
        {
            await importService.Parse(model);
            return View("Sosatt");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}