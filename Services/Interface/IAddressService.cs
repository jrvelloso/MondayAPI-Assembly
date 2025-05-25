//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface IAddressService
    {
        Task<IEnumerable<Address>> GetAll();
        Task<Address> GetById(int id);
        Task<Address> Create(Address address);
        Task<bool> Update(Address address);
        Task<bool> Delete(Address address);
    }
}