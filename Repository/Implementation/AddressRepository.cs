using Microsoft.EntityFrameworkCore;
using Monday.Models;
using Monday.Repository.Interfaces;

namespace Monday.Repository.Implementation
{

    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        protected readonly DbContext _context;

        public AddressRepository(DbContextMonday context)
           : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


    }
}
