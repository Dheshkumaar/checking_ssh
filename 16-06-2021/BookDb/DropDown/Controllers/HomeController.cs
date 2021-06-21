using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DropDown.Models;
using System.Web.Mvc;

namespace DropDown.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            AdventureWorks2019Entities mvc = new AdventureWorks2019Entities();
            Dropdown drp = new Dropdown();
            foreach (var item in mvc.ProductCategories)
            {
                drp.ProductCategory.Add(new SelectListItem { Text = item.Name, Value = item.ProductCategoryID.ToString() });
            }
            return View(drp);
        }
        [HttpPost]
        public ActionResult Index(int? ProductCategoryID, int? ProductSubcategoryID, int? ProductID)
        {
            AdventureWorks2019Entities mvc = new AdventureWorks2019Entities();
            Dropdown drp = new Dropdown();
            foreach (var item in mvc.ProductCategories)
            {
                drp.ProductCategory.Add(new SelectListItem { Text = item.Name, Value = item.ProductCategoryID.ToString() });
            }
            if (ProductCategoryID.HasValue)
            {
                var subcategory = (from e in mvc.ProductSubcategories
                                   where e.ProductCategoryID == ProductCategoryID.Value
                                   select e).ToList();
                foreach (var item in subcategory)
                {
                    drp.ProductSubCategory.Add(new SelectListItem { Text = item.Name, Value = item.ProductSubcategoryID.ToString() });
                }

                if (ProductSubcategoryID.HasValue)
                {
                    var products = (from e in mvc.Products
                                    where e.ProductSubcategoryID == ProductSubcategoryID.Value
                                    select e).ToList();
                    foreach (var item in products)
                    {
                        drp.Products.Add(new SelectListItem { Text = item.Name, Value = item.ProductID.ToString() });
                    }
                }
            }
            return View(drp);
        }
    }
}