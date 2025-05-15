//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<Product> Add(Product product);
        Task<bool> Update(Product product);
        Task<bool> Delete(Product product);
    }
}