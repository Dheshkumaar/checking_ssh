using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcRegister.Models
{
    public class UserModel
    {
        [Key]
        public string Username { get; set; }
        [Required]
        public string password { get; set; }
    }
}
