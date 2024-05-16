using Microsoft.AspNetCore.Mvc;

namespace ASP_1.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
