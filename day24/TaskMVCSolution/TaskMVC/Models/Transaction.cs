using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskMVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransActionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int AccountNumber { get; set; }
        public float Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
