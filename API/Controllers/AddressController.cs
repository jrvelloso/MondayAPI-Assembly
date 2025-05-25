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
        public async Task<Address> GetById(int id)
        {
            var address = await _addressService.GetById(id);

            return address;
        }

        [HttpGet("GettAll")]
        public async Task<IEnumerable<Address>> GetAll()
        {
            var address = await _addressService.GetAll();
            return address.ToList();
        }

        [HttpPost]
        public async Task<string> Create(Address address)
        {
            string message = "";
            await _addressService.Create(address);

            return message;
        }

        [HttpPut]
        public async Task<bool> Update(Address address)
        {
            var existingAddress = await _addressService.Update(address);
            return true;
        }

        [HttpDelete]
        public async Task<bool> Delete(Address address)
        {
            var existingAddress = await _addressService.Delete(address);
            return true;
        }
    }
}
