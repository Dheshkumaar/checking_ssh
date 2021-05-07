using System;
using EFCoreEg.EntityModel;
using System.Linq;

namespace EFCoreEg
{
    class Program
    {
        public static EntityContext db = new EntityContext();
        public static Employ e = new Employ();
        static void Main(string[] args)
        {
            PrintMenu();
        }

        private static void SelectData()
        {
            var result = db.Employs.ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Age);
            }
        }
        private static void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("MENU DETAILS:");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Select Your Choice");
                Console.WriteLine("1. Create Products to the Database");
                Console.WriteLine("2. Print/Read all the products");
                Console.WriteLine("3. Delete the product from Database");
                Console.WriteLine("4. Exit From the Application");
                Console.WriteLine("Select your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        e = AcceptData();
                        InsertData(e);
                        break;
                    case 2:
                        SelectData();
                        break;
                    case 3:
                        Console.WriteLine("Enter the id to delete");
                        int id = Convert.ToInt32(Console.ReadLine());
                        DeleteData(id);
                        break;
                    case 4:
                        Console.WriteLine("Exiting........!");
                        break;
                    default:
                        Console.WriteLine("Invalied choice");
                        break;
                }
            } while (choice != 4);
        }
        private static void DeleteData(int id)
        {
            e = db.Employs.Find(id);
            if(e == null)
                Console.WriteLine("No such employee exists");
            else
            {
                db.Employs.Remove(e);
                db.SaveChanges(); 
                Console.WriteLine("Record Deleted");
            }
        }
        private static void InsertData(Employ e1)
        {
            db.Employs.Add(e1);
            db.SaveChanges();
            Console.WriteLine("Record inserted");
        }
        private static Employ AcceptData()
        {
            Console.WriteLine("Enter name,age,phone,gender,email");
            e.Name = Console.ReadLine();
            e.Age = Convert.ToInt32(Console.ReadLine());
            e.Phone = Console.ReadLine();
            e.Gender = Console.ReadLine();
            e.Email = Console.ReadLine();
            return e;

        }

    }
}
