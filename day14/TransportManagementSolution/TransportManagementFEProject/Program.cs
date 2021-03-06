using System;
using TransportManagementBLLibrary;

namespace TransportManagementFEProject
{
    class Program
    {
        EmployeeLogin login;
        EmployeeRepo employeeRepo;
        EmployeeCRUD employeeCRUD;
        public Program()
        {
            employeeRepo = new EmployeeRepo();
            login = new EmployeeLogin(employeeRepo);
            employeeCRUD = new EmployeeCRUD(employeeRepo);
        }
        void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Register");
                Console.WriteLine("3.Print Employees");
                Console.WriteLine("4.Delete an employee");
                Console.WriteLine("5.ADD an employee");
                Console.WriteLine("6.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        login.Login();
                        break;
                    case 2:
                        login.Register();
                        break;
                    case 3:
                        employeeCRUD.PrintAllEmployees();
                        break;
                    case 4:
                        employeeCRUD.DeleteEmployee();
                        break;
                    case 5:
                        employeeCRUD.AddEmployee();
                        break;
                    case 6:
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }
            } while (choice!=6);
        }
        static void Main(string[] args)
        {
            new Program().PrintMenu();
        }
    }
}
