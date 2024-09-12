using ProductsManagementAPI.Models;

namespace ProductsManagementAPI.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product productObj);
        void UpdateProduct(Product obj);
        Product DeleteProduct(int id);
        List<Product> GetProductsByCategory(string category);
        List<Product> GetOutOfStockProducts();
        List<Product> GetProductsInGivenRange(int price1,int price2);
        List<string> GetCategoryNames();
    }
}
