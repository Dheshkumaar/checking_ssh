using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportManagementBLLibrary;

namespace TransportManagementFEProject
{
    class EmployeeCRUD
    {
        IRepo<Employee> repo;
        public EmployeeCRUD() {   }
        public EmployeeCRUD(IRepo<Employee> repo)
        {
            this.repo = repo;
        }
        public void AddEmployee()
        {
            Employee employee = new Employee();
            employee.GetEmployeeDetails();
            repo.Add(employee);
        }
        public void PrintAllEmployees()
        {
            var employees = repo.GetAll();
            try
            {
                foreach (var item in employees)
                {
                    Console.WriteLine(item);
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Empty record");
            }
            
        }
        public void DeleteEmployee()
        {
            Console.WriteLine("Please enter the employee Id to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            Employee employee = repo.Get(id);
            if (employee == null)
                Console.WriteLine("Cannot delete .No such employee");
            else
                repo.Delete(id);
        }
    }
}
