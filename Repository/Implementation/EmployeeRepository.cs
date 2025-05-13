using Microsoft.EntityFrameworkCore;
using Monday.Models;
using Monday.Repository.Interfaces;

namespace Monday.Repository.Implementation
{

    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        protected readonly DbContext _context;

        public EmployeeRepository(DbContextMonday context)
           : base(context)
        {

        }

        public async Task<List<Employee>> GetAllIncluded()
        {
            return await _context.Set<Employee>()
                 .Include(x => x.Address)
                 .Include(x => x.Job)
                 .ToListAsync();
        }
        public async Task<Employee> GetByIdIncluded(int id)
        {
            var employee = await _context.Set<Employee>()
                .Include(x => x.Address)
                .Include(x => x.Job)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (employee == null)
            {
                throw new InvalidOperationException("Employee not founded.");
            }
            return employee;
        }

        public async Task<Employee> GetByNifIncluded(string nif)
        {
            return await _context.Set<Employee>()
                 .Include(x => x.Address)
                 .Include(x => x.Job)
                 .FirstOrDefaultAsync(e => e.NIF == nif);
        }
    }
}

