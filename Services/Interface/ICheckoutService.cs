//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface ICheckoutService
    {
        Task<IEnumerable<Checkout>> GetAll();
        Task<Checkout> GetById(int id);
        Task<string> Create(CheckoutDto checkoutDto);
        Task<bool> Update(Checkout checkout);
        Task<bool> Delete(Checkout checkout);
        Task<decimal> CalculateTotalPrice(List<CheckoutProduct> products);

    }
}