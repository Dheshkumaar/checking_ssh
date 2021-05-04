using System;

namespace TransportManagementFEProject
{
    class Program
    {
        EmployeeLogin login;
        public Program()
        {
            login = new EmployeeLogin();
        }
        void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Register");
                Console.WriteLine(" 3.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        login.Login();
                        break;
                    case 2:
                        login.Register();
                        break;
                    default:
                        Console.WriteLine("Invalid entry");
                        break;
                }
            } while (choice!=3);
        }
        static void Main(string[] args)
        {
            new Program().PrintMenu();
        }
    }
}
