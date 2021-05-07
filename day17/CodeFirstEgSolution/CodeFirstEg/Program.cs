using Microsoft.EntityFrameworkCore;
using System;

namespace CodeFirstEg
{
    class Program
    {
        //public static EFContext db = new EFContext();
        public static Product p = new Product();
        static void Main(string[] args)
        {
            PrintMenu();
        }
        private static void AddProduct(Product p1)
        {
            using (var db = new EFContext())
            {
                db.Products.Add(p1);
                db.SaveChanges();
                Console.WriteLine("Record added successfully");
            }
        }
        private static void DeleteProduct(int id)
        {
            using (var db = new EFContext()) 
            { 
                p = GetProductByID(id);
                if(p == null)
                     Console.WriteLine("No such products existed");
                else
                {
                    db.Products.Remove(p);
                    db.SaveChanges();
                    Console.WriteLine("product deleted");
                }
            }
        }
        private static void UpdateProduct(int id)
        {
            using (var db= new EFContext())
            {
                p = GetProductByID(id);
                Console.WriteLine(p.ToString());
                p = AcceptDetails();
                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private static Product GetProductByID(int id)
        {
            using (var db = new EFContext())
            {
                p = db.Products.Find(id);
            }
            return p;
        }

        private static Product AcceptDetails()
        {
            Console.WriteLine("Enter Product Name, Price, quantity");
            p.PName = Console.ReadLine();
            p.Price = Convert.ToInt32(Console.ReadLine());
            p.Qty = Convert.ToInt32(Console.ReadLine());
            return p;
        }
        private static void DisplayProducts()
        {
            using (var db = new EFContext())
            {
                foreach (var item in db.Products)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        private static void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("MENU DETAILS:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Select Your Choice");
                Console.WriteLine("1. Create Products to the Database");
                Console.WriteLine("2. Print/Read all the products");
                Console.WriteLine("3. Update the Products");
                Console.WriteLine("4. Delete the product from Database");
                Console.WriteLine("5. Exit From the Application");
                Console.WriteLine("Select your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Product p1 = AcceptDetails();
                        AddProduct(p1);
                        break;
                    case 2:
                        DisplayProducts();
                        break;
                    case 3:
                        Console.WriteLine("Enter id to update");
                        int id = Convert.ToInt32(Console.ReadLine());
                        UpdateProduct(id);
                        break;
                    case 4:
                        Console.WriteLine("Enter id to Delete");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        DeleteProduct(id1);
                        break;
                    case 5:
                        Console.WriteLine("Exiting........!");
                        break;
                    default:
                        Console.WriteLine("Invalied choice");
                        break;
                }
            } while (choice != 5);
        }
    }
}
