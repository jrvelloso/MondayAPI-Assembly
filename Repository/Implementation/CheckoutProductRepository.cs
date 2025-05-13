using Monday.Models;
using Monday.Repository.Interfaces;

namespace Monday.Repository.Implementation
{
    public class CheckoutProductRepository : GenericRepository<CheckoutProduct>, ICheckoutProductRepository
    {
        public CheckoutProductRepository(DbContextMonday context)
           : base(context) { }
    }
}
