using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Services.Interface;

namespace API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Address>>> GetAll()
        {
            var list = await _addressService.GetAll();
            return Ok(list);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetById(int id)
        {
            var item = await _addressService.GetById(id);
            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Address address)
        {
            if (address == null)
                return BadRequest("Address Fail.");

            await _addressService.Create(address);
            return Ok("Address Created Successfully!");
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Address address)
        {
            await _addressService.Update(address);
            return Ok("Update Successful!");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] Address address)
        {
            await _addressService.Delete(address);
            return Ok("Delete Successful!");
        }
    }
}
