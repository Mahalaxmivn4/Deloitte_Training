using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ProductDbContext _context;

        public HomeController(ProductDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> ptList = _context.Products.ToList();
            return View(ptList);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product obj)
        {
            _context.Products.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            Product obj = _context.Products.Find(id);
            return View(obj);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product obj = _context.Products.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            _context.Products.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Product obj = _context.Products.Find(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            if (ModelState.IsValid)
            {
                Product obj = _context.Products.Find(id);
                _context.Products.Remove(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
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
