using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeFirstEg
{
    class Category
    {
        [Key]
        public int Cid { get; set; }
        public string CName { get; set; }
    }
}
