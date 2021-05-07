using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEg
{
    class EFContext:DbContext
    {
        public EFContext()
        {  }
        private const string ConnectionString = "Server=.;Database=dbSoftura;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
     }
}
