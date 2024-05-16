using Microsoft.AspNetCore.Mvc;

namespace ASP_1.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		
	}
}
