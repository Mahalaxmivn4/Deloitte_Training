using NuGet.Protocol.Core.Types;
using WebApplication8.Models;
using WebApplication8.Repositories;
namespace WebApplication8.Services
{
    public class ProductService:IProductService
    {
        public IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }
        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public void AddProduct(Product productObj)
        {
            _repository.AddProduct(productObj);
        }
        public void UpdateProduct(Product productObj)
        {
            _repository.UpdateProduct(productObj);
        }
        public Product DeleteProduct(int id)
        {
            return _repository.DeleteProduct(id);
        }
    }
}
