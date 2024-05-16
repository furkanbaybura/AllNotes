using CeylanMotors.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CeylanMotors.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ilanlar()
        {
            return View();
        }
        public IActionResult Hakk�m�zda()
        {
            return View();
        }
        public IActionResult Iletisim()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}