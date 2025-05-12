using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Services.Interface;
using Monday.Services.Interface.Monday.Services.Interface;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentMethodController : ControllerBase
    {
        private readonly IPaymentMethodService _paymentMethodService;
        public PaymentMethodController(IPaymentMethodService paymentMethodService)
        {
            _paymentMethodService = paymentMethodService;
        }
        [HttpPost]
        public async Task<string> Create(PaymentMethod paymentMethod)
        {
            string msg = await _paymentMethodService.Create(paymentMethod);
            return msg;
        }

        [HttpGet]
        public async Task<PaymentMethod> GetById(int id)
        {
            var paymentMethod = await _paymentMethodService.GetById(id);

            return paymentMethod;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<PaymentMethod>> GetAll()
        {
            var paymentMethods = await _paymentMethodService.GetAll();
            return paymentMethods;
        }

        [HttpPut]
        public async Task<string> Update(PaymentMethod paymentMethod)
        {
            string msg = await _paymentMethodService.Update(paymentMethod);
            return msg;
        }
        [HttpDelete]
        public async Task<string> Delete(int id)
        {
            string msg = await _paymentMethodService.Delete(id);
            return msg;
        }
    }
}
