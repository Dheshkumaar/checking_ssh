using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportDALLibrary
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string VehicleNumber { get; set; }

        public override string ToString()
        {
            return "Id: " + Id + " Name: " + Name + " Phone: " + Phone + " Location: " + Location;
        }
    }
}
