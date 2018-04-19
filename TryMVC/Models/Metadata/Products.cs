using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TryMVC.Models
{
    [MetadataType(typeof(ProductsMD))]
    public partial class Products
    {
        public class ProductsMD
        {
            [Required]
            public int ProductID { get; set; }

            [Required]
            [StringLength(10, ErrorMessage = "{0} 的長度需介於 {2} 到 {1}", MinimumLength = 1)]
            public string ProductName { get; set; }

            public Nullable<int> SupplierID { get; set; }

            public Nullable<int> CategoryID { get; set; }

            [Required]
            public string QuantityPerUnit { get; set; }
            
            public Nullable<decimal> UnitPrice { get; set; }
            
            public Nullable<short> UnitsInStock { get; set; }
            
            public Nullable<short> UnitsOnOrder { get; set; }
            
            public Nullable<short> ReorderLevel { get; set; }

            [Required]
            public bool Discontinued { get; set; }
        }
    }
}