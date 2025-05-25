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
        private readonly IPaymentMethodService _paymentmethodService;

        public PaymentMethodController(IPaymentMethodService paymentmethodService)
        {
            _paymentmethodService = paymentmethodService;
        }

        [HttpGet]
        public async Task<PaymentMethod> GetById(int id)
        {
            var paymentmethod = await _paymentmethodService.GetById(id);

            return paymentmethod;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<PaymentMethod>> GetAll()
        {
            var paymentmethods = await _paymentmethodService.GetAll();
            return paymentmethods.ToList();
        }

        [HttpPost]
        public async Task<string> Create(PaymentMethod paymentmethod)
        {
            string message = "";
            await _paymentmethodService.Create(paymentmethod);

            return message;
        }

        [HttpPut]
        public async Task<bool> Update(PaymentMethod paymentmethod)
        {
            var existingPaymentMethod = await _paymentmethodService.Update(paymentmethod);
            return true;
        }

        [HttpDelete]
        public async Task<bool> Delete(PaymentMethod paymentmethod)
        {
            var existingPaymentMethod = await _paymentmethodService.Delete(paymentmethod);
            return true;
        }
    }
}
