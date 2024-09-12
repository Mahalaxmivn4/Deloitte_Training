using ProductsManagementAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace ProductsManagementAPI.Repositories
{
    public class ProductRepository:IProductRepository
    {
        public ProdDbContext _context;
        public ProductRepository(ProdDbContext context)
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
        public List<Product> GetProductsByCategory(string category)
        {
            List<Product> products = _context.Products.Where(predicate => predicate.Category == category).ToList();
            return products;
        }
        public List<Product> GetOutOfStockProducts()
        {
            List<Product> products = _context.Products.Where(predicate => predicate.Quantity==0).ToList();
            return products;
        }
        public List<Product> GetProductsInGivenRange(int price1, int price2)
        {
            List<Product> products = _context.Products.Where(predicate => predicate.UnitPrice <= price2 && predicate.UnitPrice>=price1).ToList();
            return products;
        }
        public List<string> GetCategoryNames()
        {
            List<string> categories = _context.Products.Select(p=>p.Category).Distinct().ToList();
            return categories;
        }
        
    }
}
