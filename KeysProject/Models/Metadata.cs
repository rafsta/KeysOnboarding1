using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KeysProject.Models
{
    public class ProductSoldMetadata
    {
        [Display(Name = "Customer Name")]
        public int CustomerId;
        [Display(Name = "Product Name")]
        public int ProductId;
        [Display(Name = "Store Name")]
        public int StoreId;
        [Display(Name = "Date Sold")]
        public string DateSold;
    }
}