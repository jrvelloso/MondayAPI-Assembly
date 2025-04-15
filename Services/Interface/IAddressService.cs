//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface IAddressService
    {
        Task<string> Create(Address address);
        Task<string> Delete(int id);
        Task<List<Address>> GetAll();
        Task<Address> GetById(int id);
        Task<string> Update(Address address);
    }
}