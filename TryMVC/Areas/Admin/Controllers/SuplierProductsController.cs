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

        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var supplier = db.Suppliers.Find(id);
            var productCollection = db.Products.Where(x => x.CategoryID == id).ToList();

            var viewModel = new SuplierProductsViewModel();
            viewModel.Supplier = supplier;
            viewModel.ProductCollection = productCollection;

            return View(viewModel);
        }
    }
}