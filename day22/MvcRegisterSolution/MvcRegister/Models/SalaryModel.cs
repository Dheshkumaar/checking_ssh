using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRegister.Models
{
    public class SalaryModel
    {
        [Key]
        public int Salary_ID { get; set; }
        public double salary { get; set; }
        public DateTime date { get; set; }
        
        public int Emp_Id { get; set; }
        [ForeignKey("Emp_Id")]
        public EmployeeModel employeeModel { get; set; }

    }
}
