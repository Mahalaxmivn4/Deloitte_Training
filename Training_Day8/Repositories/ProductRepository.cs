using Microsoft.EntityFrameworkCore;
using WebApplication8.Models;

namespace WebApplication8.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public SalesDbContext _context;
        public ProductRepository(SalesDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = _context.Products.ToList();
            return products;
        }
        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public void AddProduct(Product productObj)
        {
            _context.Products.Add(productObj);
            _context.SaveChanges();
        }
        public void UpdateProduct(Product obj)
        {
            _context.Products.Update(obj);
            _context.SaveChanges();
        }
        public Product DeleteProduct(int id)
        {
            Product obj = _context.Products.Find(id);
            _context.Products.Remove(obj);
            _context.SaveChanges();
            return obj;
        }
    }
}
