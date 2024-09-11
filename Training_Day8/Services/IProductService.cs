using WebApplication8.Models;

namespace WebApplication8.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product productObj);
        void UpdateProduct(Product obj);
        Product DeleteProduct(int id);
    }
    
}
