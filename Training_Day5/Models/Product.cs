using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
    }


    // DbContext used to perform operations on database tables
    public class ProductDbContext : DbContext
    {
        // This property refer the databse table 
        // Multiple tables required multiple properties
        public DbSet<Product> Products { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
         : base(options)
        {

        }


    }
}