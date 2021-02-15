using System;
using System.Collections.Generic;
using System.Text;
using EFCorePractice.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractice.Data
{
    public class ShopContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = SABBIR\\MSSQLSERVER01; Database = MyDemoShop; User Id = sab; Password = 123456;");
        }
    }
}
