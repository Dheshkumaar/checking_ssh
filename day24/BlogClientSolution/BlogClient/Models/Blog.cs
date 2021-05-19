using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogClient.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public float Ratings { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
    }
}
