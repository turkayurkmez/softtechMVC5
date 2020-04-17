using SimpleStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleStoreApplication.Data
{
    public class SimpleStoreDbContext :DbContext
    {
        public SimpleStoreDbContext():base("name=SimpleStoreDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;    
        }

        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //fluently EF configuration
            //modelBuilder.Entity<Product>().Property(x => x.ProductName).IsRequired();
           // modelBuilder.Entity<Product>().HasMany(x => x.Category).WithRequired(x);

        }
    }
}