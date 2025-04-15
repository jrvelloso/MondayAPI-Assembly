using Microsoft.EntityFrameworkCore;
using Monday.Models;
using Monday.Repository.Interfaces;

namespace Monday.Repository.Implementation
{

    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        protected readonly DbContext _context;

        public EmployeeRepository(DbContextMonday context)
           : base(context) { }
    }
}
