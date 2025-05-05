using Microsoft.AspNetCore.Mvc;
using Monday.Models;
using Monday.Services.Implementation;
using Monday.Services.Interface;
using System.Net;

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
        public async Task<string> Create(Address address)
        {
            string msg = await _addressService.Create(address);
            return msg;
        }

        [HttpGet]
        public async Task<Address> GetById(int id)
        {
            var address = await _addressService.GetById(id);

            return address;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Address>> GetAll()
        {
            var addresses = await _addressService.GetAll();
            return addresses;
        }

        [HttpPut]
        public async Task<string> Update(Address address)
        {
            string msg = await _addressService.Update(address);
            return msg;
        }
        [HttpDelete]
        public async Task<string> Delete(int id)
        {
            string msg = await _addressService.Delete(id);
            return msg;
        }
    }
}
