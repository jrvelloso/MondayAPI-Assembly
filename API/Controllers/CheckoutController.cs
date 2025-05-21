using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Services.Interface;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckoutController : ControllerBase
    {
        private readonly ICheckoutService _checkoutService;

        public CheckoutController(ICheckoutService checkoutService)
        {
            _checkoutService = checkoutService;
        }

        [HttpGet]
        public async Task<Checkout> GetById(int id)
        {
            var checkout = await _checkoutService.GetById(id);

            return checkout;
        }

        [HttpGet("GetAll")]
        public async Task<List<Checkout>> GetAll()
        {
            var checkout = await _checkoutService.GetAll();
            return checkout.ToList();
        }

        [HttpPost]
        public async Task<string> Create(Checkout checkout)
        {
            string message = "";
            await _checkoutService.Create(checkout);

            return message;
        }

        [HttpPut]
        public async Task<bool> Update(Checkout checkout)
        {
            var existingCheckout = await _checkoutService.Update(checkout);
            return true;
        }

        [HttpDelete]
        public async Task<bool> Delete(Checkout checkout)
        {
            var existingCheckout = await _checkoutService.Delete(checkout);
            return true;
        }
    }
}
