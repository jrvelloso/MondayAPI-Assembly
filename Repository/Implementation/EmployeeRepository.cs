using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
            return await _context.Set<Employee>()
                 .Include(x => x.Address)
                 .Include(x => x.Job)
                 .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Employee> GetByNifIncluded(string nif)
        {
            return await _context.Set<Employee>()
                 .Include(x => x.Address)
                 .Include(x => x.Job)
                 .FirstOrDefaultAsync(e => e.NIF == nif);
        }
        //public async Task<Employee> UpdateIncluded(int id)
        //{
        //    return await _context.Update<Employee>(id);
        //    //.Include(x => x.Address)
        //    //.Include(x => x.Job)
        //    //.FirstOrDefaultAsync(e => e.Id == employee.Id);
        //}
    }
}

