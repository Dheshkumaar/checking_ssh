using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRegister.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Emp_Id { get; set; }
        public string Name { get; set; } 
        public int Age { get; set; }
        public string Username { get; set; }
        [ForeignKey("Username")]
        public UserModel UserModel { get; set; }

    }
}
