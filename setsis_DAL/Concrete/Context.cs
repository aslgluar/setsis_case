using Microsoft.EntityFrameworkCore;
using setsis_EL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace setsis_DAL.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HJKG5EO; database=coreDB;integrated security=true;TrustServerCertificate=True");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
