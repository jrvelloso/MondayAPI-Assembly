//ToDoMonday 
using Monday.Models;

namespace Monday.Services.Interface
{
    public interface IProductService
    {
        Task<string> Create(Product product);
        Task<string> Delete(int id);
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<string> Update(Product product);
    }
}