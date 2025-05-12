using Microsoft.AspNetCore.Mvc;
using Monday.Models;
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
        [HttpGet]
        public async Task<ActionResult<List<PaymentMethod>>> GetAll()
        {
            var list = await _paymentMethodService.GetAll();
            return Ok(list);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentMethod>> GetById(object id)
        {
            var item = await _paymentMethodService.GetById(id);
            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PaymentMethod paymentMethod)
        {
            if (paymentMethod == null)
                return BadRequest("Payment Fail.");

            await _paymentMethodService.Create(paymentMethod);
            return Ok("Payment Created Successful!");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] PaymentMethod paymentMethod)
        {
            await _paymentMethodService.Update(paymentMethod);
            return Ok("Update Successful!");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] PaymentMethod paymentMethod)
        {
            await _paymentMethodService.Delete(paymentMethod);
            return Ok("Delete Successful!");
        }
    }
}
