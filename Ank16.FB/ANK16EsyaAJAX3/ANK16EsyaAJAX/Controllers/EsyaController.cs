using ANK16EsyaAJAX.Context;
using ANK16EsyaAJAX.Data;
using Microsoft.AspNetCore.Mvc;

namespace ANK16EsyaAJAX.Controllers
{
    public class EsyaController : Controller
    {
        private readonly EsyaDbContext _db;

        public EsyaController(EsyaDbContext db)
        {
            _db = db;
        }

        //listelemeyi gösterecek olan view
        public IActionResult Index()
        {
            return View();
        }
        //listelemeyi yapacak olan metod
        public IActionResult Listele()
        {
            return Json(_db.Esyalar.ToList());

        }
        [HttpPost]
        public IActionResult Ekle(Esya esya)
        {
            if (esya.Ad != null && esya.Fiyat != 0)

            {
                _db.Esyalar.Add(esya);
                _db.SaveChanges();
                return Json(esya);
            }
            return new EmptyResult();

        }

        public IActionResult Sil(int id)
        {
            var silinecek = _db.Esyalar.Find(id);
            if (silinecek != null)
            {
                _db.Esyalar.Remove(silinecek);
                _db.SaveChanges();
                return Json(silinecek);

            }
          
            return View();   
        }
        public IActionResult Guncelle(int id , Esya esya)
        {
            var guncelle = _db.Esyalar.Find(id);
            if (guncelle != null)
            {

                _db.Esyalar.Update(guncelle);
                _db.SaveChanges();
            }
            return View();
        }
    }
}
