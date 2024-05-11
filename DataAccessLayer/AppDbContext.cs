using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext")
        {

        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Receipt>? Receipts { get; set; }
        public DbSet<Sales>? Sales { get; set; }
        public DbSet<Excuse>? Excuses { get; set; }
        public DbSet<AliasName>? AliasNames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Here you can customize table mappings
        }
    }
}
