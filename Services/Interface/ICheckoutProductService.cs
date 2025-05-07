using Monday.Models;

namespace Monday.Services.Interface
{
    public interface ICheckoutProductService
    {
        Task<string> Create(CheckoutProduct productList);
        Task<string> Delete(int id);
        Task<List<CheckoutProduct>> GetAll();
        Task<CheckoutProduct> GetById(int id);
        Task<string> Update(CheckoutProduct productList);
    }
}
