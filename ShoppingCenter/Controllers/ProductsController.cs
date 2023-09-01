using Microsoft.AspNetCore.Mvc;
using ShoppingCenter.Data;
using ShoppingCenter.Models;

namespace ShoppingCenter.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContex db;
        public ProductsController(AppDbContex db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> objCategoryList = db.Products.ToList();
            return View(objCategoryList);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Product obj)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var obj = db.Products.Find(id);

            if (obj == null)
                return NotFound();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product p)
        {
            if (ModelState.IsValid)
            {
                db.Products.Update(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var obj = db.Products.Find(id);

            if (obj == null)
                return NotFound();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Product p)
        {
            db.Products.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
