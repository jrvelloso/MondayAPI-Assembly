//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface IAddressService
    {
        Task<List<Address>> GetAll();
        Task<Address> GetById(int id);
        Task<Address> Create(Address address);
        Task<Address> Update(Address address);
        Task<Address> Delete(Address address);
    }
}