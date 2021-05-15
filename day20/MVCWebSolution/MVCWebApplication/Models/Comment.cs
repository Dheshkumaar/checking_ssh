using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebApplication.Models
{
    public class Comment
    {
        public int PostId { get; set; }
        public int Id { get; set; }
        public string CommenText { get; set; }
    }
}
