using Microsoft.AspNetCore.Mvc;

namespace ASP_1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
