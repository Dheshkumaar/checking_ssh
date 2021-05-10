using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQEg
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public float Marks { get; set; }
        public DateTime Doj { get; set; }
        public string City { get; set; }
        public Student()
        {  }
        public Student(int sid,string sname,float marks,DateTime doj,string city)
        {
            StudentId = sid;
            StudentName = sname;
            Marks = marks;
            Doj = doj;
            City = city;
        }
        public override string ToString()
        {
            return String.Format(StudentId + "---" + StudentName + "***" + Marks
                + "---" + Doj + "***" + City);
        }
    }
}
