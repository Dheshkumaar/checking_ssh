using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using Task2.Models;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            AdventureWorks2019Entities mvc = new AdventureWorks2019Entities();
            var query = new SelectList(mvc.Departments.ToList(), "DepartmentID", "Name");
            ViewData["DeptEF"] = query;
            return View();
        }
        public ActionResult Index1()
        {
            table table = new table();
            DataTable dt = table.GetDepartment();
            return View(dt);
        }
        public ActionResult Display1(FormCollection form)
        {
            table table = new table();
            string name = form["Department"];
            int deptId = table.DepartmentName(name);
            DataTable dt = table.Display(deptId);
            return View(dt);
        }

        public ActionResult Display(FormCollection form)
        {
            AdventureWorks2019Entities mvc = new AdventureWorks2019Entities();
            int Id = Convert.ToInt32(form["Department"]);
            List<Person> person = mvc.People.ToList();
            List<Employee> employees = mvc.Employees.ToList();
            List<EmployeeDepartmentHistory> employeeDepartments = mvc.EmployeeDepartmentHistories.ToList();
            var query = from e in employees
                        join p in person on e.BusinessEntityID equals p.BusinessEntityID into table1
                        from d in table1.ToList()
                        join emp in employeeDepartments on e.BusinessEntityID equals emp.BusinessEntityID into table2
                        from i in table2.ToList()
                        where i.DepartmentID == Id
                        select new ClassModel
                        {
                            employee = e,
                            person = d,
                            EmployeeDepartment = i
                        };
            return View(query);
        }
    }
}