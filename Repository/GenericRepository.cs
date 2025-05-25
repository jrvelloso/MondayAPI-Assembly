using Microsoft.EntityFrameworkCore;

namespace Monday.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContextMonday _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DbContextMonday context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = context.Set<T>();
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }
        public async Task AddListAsync(List<T> listEntity)
        {
            foreach (var entity in listEntity)
            {
                await _dbSet.AddAsync(entity);

            }
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<int> SaveAsync()
        {
            int id = await _context.SaveChangesAsync();
            return id;
        }

    }
}
