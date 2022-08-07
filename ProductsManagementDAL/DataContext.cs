using Microsoft.EntityFrameworkCore;
using ProductsManagementEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagementDAL
{
    public class DataContext: DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options) 
            => options.UseSqlServer("server = localhost; Database = ProductsManagementDB; Trusted_Connection = True;");

        public DbSet<Products> Products { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
