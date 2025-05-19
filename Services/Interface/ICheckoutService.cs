//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface ICheckoutService
    {
        Task<List<Checkout>> GetAll();
        Task<Checkout> GetById(int id);
        Task<Checkout> Create(Checkout checkout);
        Task<bool> Update(Checkout checkout);
        Task<bool> Delete(Checkout checkout);
    }
}