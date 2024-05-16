using ASP8Uygulama.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP8Uygulama.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public void CookieAta(string anahtar,string deger)
        {
            Response.Cookies.Append(anahtar, deger);
        }
        public string CookieGetir(string anahtar)
        {
             HttpContext.Request.Cookies.TryGetValue(anahtar,out string sonuc);
            return sonuc;
           
        }
        public IActionResult CookieOLustur()
        {
            CookieAta("Yemek", "Kebap");
            return RedirectToAction("Index");
        }



        public void SessionAta(string anahtar, string deger)
        {
            HttpContext.Session.SetString(anahtar,deger);
        }
        public string SessionGetir(string anahtar)
        {
            return HttpContext.Session.GetString(anahtar);
        }

        public IActionResult SessionOLustur()
        {
            SessionAta("Malzeme", "Cimento");
            return RedirectToAction("Privacy");
        }
        public IActionResult Session()
        {
            return View();
        }
        public IActionResult Index()
        {
            
            return View(model:CookieGetir("Yemek"));
        }

        public IActionResult Privacy()
        {
            return View(model:SessionGetir("Malzeme"));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
