using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Services;
using WebApplication8.Models;
using WebApplication8.Repositories;
using Microsoft.EntityFrameworkCore;
namespace WebApplication8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        public IProductService _service;
        public ProductApiController(IProductService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_service.GetAllProducts());
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product obj = _service.GetProductById(id);

            if (obj == null)
            {
                return NotFound(new { result = "Requested Product details are not available." });
            }
            else
            {
                return Ok(obj);
            }
        }


        [HttpPost]
        public IActionResult CreateStudent(Product obj)
        {
            _service.AddProduct(obj);
            return Ok(new { result = "Product Details added to db" });
        }
        [HttpPut]
        public IActionResult EditProduct(Product obj)
        {
            _service.UpdateProduct(obj);
            return Ok(new { result = "Product details updated in server." });
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            Product obj = _service.DeleteProduct(id);

            if (obj != null)
            {


                return Ok(new { status = "Product details are deleted from server." });
            }
            else
            {
                return NotFound(new { status = "Requested Product details does not exists." });
            }

        }
    }
}
    
