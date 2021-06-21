using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCusgDPR.Models
{
    public class BookModel
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public double price { get; set; }
    }
}