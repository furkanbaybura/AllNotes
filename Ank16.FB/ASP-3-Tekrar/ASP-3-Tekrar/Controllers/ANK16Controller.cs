using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace ASP3Tekrar.Controllers
{
    public class ANK16Controller : Controller
    {
        public IActionResult Sınıf()
        {
            return View();
        }
        public IActionResult Rasgele()
        {
            Random rnd = new Random();
            int sayi= rnd.Next(1,101);
            ViewBag.Sayi = sayi;
            return View();
           
        }
        public IActionResult Sayilar()
        {
            List<int> sayilar =
                 new List<int>();
            for (int i = 1; i < 21; i++)
            {
                sayilar.Add(i);
            }
            ViewBag.Sayilar = sayilar;
            return View();

            
        }
        public IActionResult Bilgiler()
        {
            
            return View();
        }
        public IActionResult Login(string name, string surname, string age)
        {
            ViewBag.Name = name;
            ViewBag.Age = age;
            ViewBag.Surname = surname;
            return View();
        } 

       
    }
   
}
