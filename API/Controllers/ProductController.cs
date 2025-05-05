using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Services.Interface;
using Monday.Services.Interface.Monday.Services.Interface;

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
        public async Task<string> Create(Product product)
        {
            string msg = await _productService.Create(product);
            return msg;
        }

        [HttpGet]
        public async Task<Product> GetById(int id)
        {
            var product = await _productService.GetById(id);

            return product;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Product>> GetAll()
        {
            var products = await _productService.GetAll();
            return products;
        }

        [HttpPut]
        public async Task<string> Update(Product product)
        {
            string msg = await _productService.Update(product);
            return msg;
        }
        [HttpDelete]
        public async Task<string> Delete(int id)
        {
            string msg = await _productService.Delete(id);
            return msg;
        }
    }
}
