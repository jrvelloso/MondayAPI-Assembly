using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Services.Interface;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckoutProductController : ControllerBase
    {
        private readonly ICheckoutProductService _checkoutProductService;
        public CheckoutProductController(ICheckoutProductService checkoutProductService)
        {
            _checkoutProductService = checkoutProductService;
        }
        [HttpPost]
        public async Task<string> Create(CheckoutProduct checkoutProduct)
        {
            string msg = await _checkoutProductService.Create(checkoutProduct);
            return msg;
        }

        [HttpGet]
        public async Task<CheckoutProduct> GetById(int id)
        {
            var checkoutProduct = await _checkoutProductService.GetById(id);

            return checkoutProduct;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<CheckoutProduct>> GetAll()
        {
            var checkoutProducts = await _checkoutProductService.GetAll();
            return checkoutProducts;
        }

        [HttpPut]
        public async Task<string> Update(CheckoutProduct checkoutProduct)
        {
            string msg = await _checkoutProductService.Update(checkoutProduct);
            return msg;
        }
        [HttpDelete]
        public async Task<string> Delete(int id)
        {
            string msg = await _checkoutProductService.Delete(id);
            return msg;
        }
    }
}
