using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreEg.EntityModel
{
    public partial class Employ
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
}
