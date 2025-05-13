using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Models.Dtos;
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
        [HttpPost]
        public async Task<string> Create(CheckoutDto checkoutDto)
        {
            string msg = await _checkoutService.Create(checkoutDto);
            return msg;
        }

        [HttpGet]
        public async Task<Checkout> GetById(int id)
        {
            var checkout = await _checkoutService.GetById(id);

            return checkout;
        }
        [HttpGet("GetByIdIncluded")]
        public async Task<Checkout> GetByIdIncluded(int id)
        {
            var checkout = await _checkoutService.GetByIdIncluded(id);
            return checkout;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Checkout>> GetAll()
        {
            var checkouts = await _checkoutService.GetAll();
            return checkouts;
        }

        [HttpPut]
        public async Task<string> Update(Checkout checkout)
        {
            string msg = await _checkoutService.Update(checkout);
            return msg;
        }
        [HttpDelete]
        public async Task<string> Delete(int id)
        {
            string msg = await _checkoutService.Delete(id);
            return msg;
        }
    }
}
