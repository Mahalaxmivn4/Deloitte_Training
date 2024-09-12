using Microsoft.EntityFrameworkCore;

namespace ProductsManagementAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public string Description { get; set; }
    }
    public class ProdDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProdDbContext(DbContextOptions<ProdDbContext> options)
         : base(options)
        {

        }
    }
}
