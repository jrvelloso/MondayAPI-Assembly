//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class AddressService : IAddressService
    {
        private IAddressRepository _addressRepository { get; set; }


        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<List<Address>> GetAll()
        {
            var all = await _addressRepository.GetAllAsync();
            return all.ToList();
        }
    }
}
