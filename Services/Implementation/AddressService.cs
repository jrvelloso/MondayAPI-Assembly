//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Repository.Implementation;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;
using System.Net;

namespace Monday.Services.Implementation
{
    public class AddressService : IAddressService
    {
        private IAddressRepository _addressRepository { get; set; }


        public AddressService(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<List<Address>> GetAllAsync()
        {
            var all = await _addressRepository.GetAllAsync();
            return all.ToList();
        }

        public async Task<Address> GetByIdAsync(int id)
        {
            Address address = await _addressRepository.GetByIdAsync(id);
            return address;
        }

        public async Task<Address> AddAsync(Address address)
        {
            await _addressRepository.AddAsync(address);
            await _addressRepository.SaveAsync();
            return address;
        }
        public async Task<bool> Update(Address address)
        {
            var existingAddress = await _addressRepository.GetByIdAsync(address.Id);

            if (existingAddress == null)
                return false;

            _addressRepository.Update(address);
            await _addressRepository.SaveAsync();
            return true;
        }

        public async Task<bool> Delete(Address address)
        {
            var existingAddress = await _addressRepository.GetByIdAsync(address.Id);

            if (existingAddress == null)
                return false;

            _addressRepository.Delete(address);
            await _addressRepository.SaveAsync();
            return true;
        }
    }
}
