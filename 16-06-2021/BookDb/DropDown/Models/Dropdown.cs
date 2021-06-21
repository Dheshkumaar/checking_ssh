using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDown.Models
{
    public class Dropdown
    {
        public Dropdown()
        {
            this.ProductCategory = new List<SelectListItem>();
            this.ProductSubCategory = new List<SelectListItem>();
            this.Products = new List<SelectListItem>();
        }

        public List<SelectListItem> ProductCategory { get; set; }
        public List<SelectListItem> ProductSubCategory { get; set; }
        public List<SelectListItem> Products { get; set; }

        public int ProductCategoryID { get; set; }
        public int ProductSubcategoryID { get; set; }
        public int ProductID { get; set; }

    }
}