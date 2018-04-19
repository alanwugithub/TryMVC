using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryMVC.Models;

namespace TryMVC.Areas.Admin.ViewModels
{
    public class SuplierProductsViewModel
    {
        public Suppliers Supplier { get; set; }

        public IEnumerable<Products> ProductCollection { get; set; }
    }
}