using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApplication.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string PostText { get; set; }
        public string Category { get; set; }
    }
}
