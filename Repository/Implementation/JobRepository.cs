using Monday.Models;
using Monday.Repository.Interfaces;

namespace Monday.Repository.Implementation
{

    public class JobRepository : GenericRepository<Job>, IJobRepository
    {
        public JobRepository(DbContextMonday context)
           : base(context) { }
    }
}
