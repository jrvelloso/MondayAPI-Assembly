//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Repository.Implementation;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class AddressService : IAddressService
    {
        private IAddressRepository _addressRepository { get; set; }

        public AddressService(IAddressRepository _addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task<List<Address>> GetAll()
        {
            var all = await _addressRepository.GetAllAsync();
            return all.ToList();
        }

        public async Task Create(Address address)
        {
            await _addressRepository.AddAsync(address);
            await _addressRepository.SaveAsync();
        }

        public async Task<Address?> GetById(int id)
        {
            return await _addressRepository.GetByIdAsync(id);
        }

        public async Task Update(Address address)
        {
            _addressRepository.Update(address);
            await _addressRepository.SaveAsync();
        }
        public async Task Delete(Address address)
        {
            _addressRepository.Delete(address);
            await _addressRepository.SaveAsync();
        }
    }
}
