using Microsoft.EntityFrameworkCore;
using Monday.Models;
using Monday.Repository.Interfaces;

namespace Monday.Repository.Implementation
{

    public class JobRepository : GenericRepository<Job>, IJobRepository
    {
        protected readonly DbContext _context;

        public JobRepository(DbContextMonday context)
           : base(context) { }
    }
}
