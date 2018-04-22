using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryMVC.Models;
using TryMVC.Areas.Admin.ViewModels;
using System.Net;

namespace TryMVC.Areas.Admin.Controllers
{
    public class SuplierProductsController : Controller
    {
        private NorthWindEntities db = new NorthWindEntities();

        // GET: Admin/SuplierProducts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id = 1)
        {
            var supplier = db.Suppliers.Find(id);

            if (supplier == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            { 
                var viewModel = new SuplierProductsViewModel()
                {
                    Supplier = supplier,
                    ProductCollection = db.Products.Where(x => x.SupplierID == id).ToList()
                };

                return View(viewModel);
            }
        }

        public ActionResult Edit(int? id)
        {
            return RedirectToAction("Edit", "Products", new { id = id });
        }

        public ActionResult Delete(int? id)
        {
            return RedirectToAction("Delete", "Products", new { id = id });
        }
    }
}