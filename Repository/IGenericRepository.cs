using Microsoft.EntityFrameworkCore;

namespace Monday.Repository
{

    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(object id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task AddListAsync(List<T> listEntity);
        void Update(T entity);
        void Delete(T entity);
        Task<int> SaveAsync();
    }
}