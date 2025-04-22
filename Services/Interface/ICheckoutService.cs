//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface ICheckoutService
    {
        Task<Checkout> AddAsync(Checkout checkout);
        decimal CalculateTotalPrice(List<Product> products);
        Task DeleteAsync(int id);
        Task<IEnumerable<Checkout>> GetAllAsync();
        Task<Checkout?> GetByIdAsync(int id);
        Task UpdateAsync(Checkout checkout);
    }
}