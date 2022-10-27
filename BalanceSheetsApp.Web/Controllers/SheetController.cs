using BalanceSheetsApp.Web.Interfaces;
using BalanceSheetsApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BalanceSheetsApp.Web.Controllers
{
    public class SheetController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public SheetController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowSheet(BankViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}
