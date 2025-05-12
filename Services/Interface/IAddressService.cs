//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface IAddressService
    {
        Task<List<Address>> GetAll();
        Task<Address?> GetById(int id);
        Task Create(Address address);
        Task Update(Address address);
        Task Delete(Address address);
    }
}