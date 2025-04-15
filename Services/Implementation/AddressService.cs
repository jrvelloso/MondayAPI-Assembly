//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Repository.Implementation;
using Monday.Repository.Interfaces;

//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class AddressService : IAddressService
    {
        private IAddressRepository _addressRepository;

        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<string> Create(Address address)
        {
            await _addressRepository.AddAsync(address);
            return "Address created with success";           
        }

        public async Task<string> Delete(int id)
        {
            Address address = await _addressRepository.GetByIdAsync(id);
            if (address == null)
            {
                return "Address not founded";
            }
            _addressRepository.Delete(address);
            return "Address removed with success";
        }

        public async Task<List<Address>> GetAll()
        {
            var addresses = await _addressRepository.GetAllAsync();
            return addresses.ToList();
        }

        public async Task<Address> GetById(int id)
        {
            Address address = await _addressRepository.GetByIdAsync(id);
            return address;
        }

        public async Task<string> Update(Address address)
        {
            Address updateAddress = await _addressRepository.GetByIdAsync(address.Id);
            if (updateAddress == null)
            {
                return "Address not founded";
            }
            _addressRepository.Update(updateAddress);
            return "Address updated with sucess";
        }
    }
}
