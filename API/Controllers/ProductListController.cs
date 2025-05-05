using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Services.Implementation;
using Monday.Services.Interface;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductListController : ControllerBase
    {
        private readonly IProductListService _productListService;
        public ProductListController(IProductListService productListService)
        {
            _productListService = productListService;
        }
        public async Task<string> Create(CheckoutProduct productList)
        {
            string msg = await _productListService.Create(productList);
            return msg;
        }

        [HttpGet]
        public async Task<CheckoutProduct> GetById(int id)
        {
            var productList = await _productListService.GetById(id);

            return productList;
        }

        [HttpGet("GetByIdIncluded")]
        public async Task<CheckoutProduct> GetByIdIncluded(int id)
        {
            var productList = await _productListService.GetByIdIncluded(id);
            return productList;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<CheckoutProduct>> GetAll()
        {
            var productLists = await _productListService.GetAll();
            return productLists;
        }

        [HttpPut]
        public async Task<string> Update(CheckoutProduct productList)
        {
            string msg = await _productListService.Update(productList);
            return msg;
        }
        [HttpDelete]
        public async Task<string> Delete(int id)
        {
            string msg = await _productListService.Delete(id);
            return msg;
        }
    }
}
