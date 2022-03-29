using BusinessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new ProductRepository());
        public IActionResult Index()
        {
            return View(pm.GetList());
        }
       
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,Description,Price,UserId")] Product p)
        {
            if (ModelState.IsValid)
            {
                p.UserId = 1;
                pm.ProductAdd(p);
                return RedirectToAction(nameof(Index));
            }
            return View(p);
        }
       

        public IActionResult Delete(int id)
        {
            var productValue = pm.GetById(id);
            return View(productValue);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Product p)
        {            
            pm.ProductDelete(p);
            return RedirectToAction("Index", "Product");
        }

        public IActionResult Update(int id)
        {
            var productValue = pm.GetById(id);
            
            return View(productValue);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([Bind("ProductId,ProductName,Description,Price,UserId")] Product p)
        {
            pm.ProductUpdate(p);

            return RedirectToAction("Index", "Product");
        }

    }
}
