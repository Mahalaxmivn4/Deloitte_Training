using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication8.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category{ get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
    }


    // DbContext used to perform operations on database tables
    public class SalesDbContext : DbContext
    {
        // This property refer the databse table 
        // Multiple tables required multiple properties
        public DbSet<Product> Products { get; set; }

        public SalesDbContext(DbContextOptions<SalesDbContext> options)
         : base(options)
        {

        }


    }
}
