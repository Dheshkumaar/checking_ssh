using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportDALLibrary;

namespace TransportFEApplication
{
    class CompleteEmployee : Employee, IComparable<Employee>
    {
        const string INITIAL_PASSWORD = "1234";
        public int CompareTo([AllowNull]Employee other)
        {
            return this.Id.CompareTo(other.Id);
        }
        public CompleteEmployee()
        {  }
        public CompleteEmployee(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Password = employee.Password;
            this.VehicleNumber = employee.VehicleNumber;
            this.Phone= employee.Phone;
            this.Location = employee.Location;
        }
        public void TakeEmployeeData()
        {
            Console.WriteLine("please enter the employee name: ");
            Name = Console.ReadLine();
            Console.WriteLine("please enter the employee location: ");
            Location = Console.ReadLine();
            Console.WriteLine("Please enter the employee phone: ");
            Phone = Console.ReadLine();
            Password = INITIAL_PASSWORD;
        }
        public override string ToString()
        {
            string maskedPassword = GetMaskedPassword(Password);
            return "Id:" + Id + " Name: " + Name + " Location " + Location + " Phone: " + Phone + " Password: " + maskedPassword;
        }

        private string GetMaskedPassword(string password)
        {
            string result = password.Substring(0,2);
            for(int i = 2; i < password.Length; i++)
            {
                result += "*";
            }
            return result;
        }
    }
}
