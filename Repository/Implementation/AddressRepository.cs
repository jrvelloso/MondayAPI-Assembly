using Monday.Models;
using Monday.Repository.Interfaces;

namespace Monday.Repository.Implementation
{

    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(DbContextMonday context)
           : base(context)
        {
        }


    }
}
