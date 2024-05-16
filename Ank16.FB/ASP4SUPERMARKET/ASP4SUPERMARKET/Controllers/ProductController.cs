using ASP4SUPERMARKET.Data;
using ASP4SUPERMARKET.Data.Entities;
using ASP4SUPERMARKET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP4SUPERMARKET.Controllers
{
   
    public class ProductController : Controller
    {
        private readonly SuperMarketDbContext _context;
        public ProductController(SuperMarketDbContext context)
        {
           _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Create(ProductAddEditViewModel model)
        {
            Product product = new Product();
            product.Id = model.Id;
            product.Name = model.Name;
            product.Price = model.Price;
            product.StockStatus= model.StockStatus; 

            if(ModelState.IsValid)
            {
                _context.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Edit(ProductAddEditViewModel model)
        {
            if (model.Id == null)
            {
                return NotFound();
            }
            Product old = _context.products.Single(x=> x.Id == model.Id);
            old.Name = model.Name;
            old.Id=model.Id;
            old.Price=model.Price;
            old.StockStatus = model.StockStatus;
            _context.products.Update(old);
            _context.SaveChanges();

            if(model == null)
            {
                return NotFound();
            }
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            return View();
        }
        public IActionResult ActiveProducts()
        {
           
            var listActive = _context.products.Where(x => x.StockStatus == true).ToList();
            List<ProductAddEditViewModel> list = new List<ProductAddEditViewModel>();
            foreach (var product in listActive)
            {
                ProductAddEditViewModel model = new ProductAddEditViewModel();
                model.Id=product.Id;
                model.Price= product.Price;
                model.Name=product.Name;
                model.StockStatus = product.StockStatus;
                list.Add(model);
            }
           
            return View(list);
        }
    }
}
