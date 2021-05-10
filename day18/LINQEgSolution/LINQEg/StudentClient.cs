using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQEg
{
    class StudentClient
    {
        public static List<Student> students = new List<Student>();
        public static void Main()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("ADD an employee");
                Student stud = new Student();
                Console.WriteLine("ENTER id,name,Marks,Doj,city");
                stud.StudentId = Convert.ToInt32(Console.ReadLine());
                stud.StudentName = Console.ReadLine();
                stud.Marks = Convert.ToSingle(Console.ReadLine());
                stud.Doj = Convert.ToDateTime(Console.ReadLine());
                stud.City = Console.ReadLine();
                students.Add(stud);
                Console.WriteLine("Enter choice:(0 to exit)");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice != 0);

            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
            #region
            //students.Add(new Student(1, "Ram", 34, DateTime.Now, "chennai"));
            //students.Add(new Student(2, "Ramesh", 89, DateTime.Now, "pune"));
            //students.Add(new Student(3, "Dheeraj", 54, DateTime.Now, "chennai"));
            //students.Add(new Student(4, "Latha", 76, DateTime.Now, "bangalore"));
            //students.Add(new Student(5, "Krish", 29, DateTime.Now, "chennai"));
            //students.Add(new Student(6, "John", 74, DateTime.Now, "pune"));
            //students.Add(new Student(7, "Paul", 66, DateTime.Now, "chennai"));
            #endregion
            Console.WriteLine("Enter the city to be searched");
            string searchCity = Console.ReadLine();
            var result = (from i in students
                           where i.City == searchCity
                           select i).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Enter the student id to be searched");
            int sid = Convert.ToInt32(Console.ReadLine());
            Student s = (from i in students
                         where i.StudentId == sid
                         select i).FirstOrDefault();
            if(s == null)
                Console.WriteLine("NO id found");
            else
                Console.WriteLine(s.ToString());
        }
    }
}
