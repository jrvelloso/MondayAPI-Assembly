using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Services.Interface;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<Product> GetById(int id)
        {
            var product = await _productService.GetById(id);

            return product;
        }

        [HttpGet]
        public async Task<List<Product>> GetAll()
        {
            var product = await _productService.GetAll();
            return product.ToList();
        }

        [HttpGet]
        public async Task<string> Create(Product product)
        {
            string message = "";
            await _productService.Create(product);

            return message;
        }

        [HttpGet]
        public async Task<bool> Update(Product product)
        {
            var existingProduct = await _productService.Update(product);
            return true;
        }

        [HttpGet]
        public async Task<bool> Delete(Product product)
        {
            var existingProduct = await _productService.Delete(product);
            return true;
        }
    }
}
