//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface ICheckoutService
    {
        Task<string> Create(Checkout checkout);
        Task<decimal> CalculateTotalPrice(List<ProductList> products);
        Task<string> Delete(int id);
        Task<IEnumerable<Checkout>> GetAll();
        Task<Checkout?> GetById(int id);
        Task<string> Update(Checkout checkout);
        Task<Checkout?> GetByIdIncluded(int id);
        Task<List<ProductList>> CreateProductList(List<ProductList> products);
    }
}