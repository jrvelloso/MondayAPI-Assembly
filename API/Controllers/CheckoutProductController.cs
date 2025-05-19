using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Services.Interface;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckoutProductController : ControllerBase
    {
        private readonly ICheckoutProductService _checkoutproductService;

        public CheckoutProductController(ICheckoutProductService checkoutproductService)
        {
            _checkoutproductService = checkoutproductService;
        }

        [HttpGet]
        public async Task<CheckoutProduct> GetById(int id)
        {
            var checkoutproduct = await _checkoutproductService.GetById(id);

            return checkoutproduct;
        }

        [HttpGet]
        public async Task<List<CheckoutProduct>> GetAll()
        {
            var checkoutproducts = await _checkoutproductService.GetAll();
            return checkoutproducts.ToList();
        }

        [HttpGet]
        public async Task<string> Create(CheckoutProduct checkoutproduct)
        {
            string message = "";
            await _checkoutproductService.Create(checkoutproduct);

            return message;
        }

        [HttpGet]
        public async Task<bool> Update(CheckoutProduct checkoutproduct)
        {
            var existingCheckoutProduct = await _checkoutproductService.Update(checkoutproduct);
            return true;
        }

        [HttpGet]
        public async Task<bool> Delete(CheckoutProduct checkoutproduct)
        {
            var existingCheckoutProduct = await _checkoutproductService.Delete(checkoutproduct);
            return true;
        }
    }
}
