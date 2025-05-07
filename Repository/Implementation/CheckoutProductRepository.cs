using Microsoft.EntityFrameworkCore;
using Monday.Models;
using Monday.Repository.Interfaces;

namespace Monday.Repository.Implementation
{
    public class CheckoutProductRepository : GenericRepository<CheckoutProduct>, ICheckoutProductRepository

    {
        protected readonly DbContext _context;

        public CheckoutProductRepository(DbContextMonday context)
           : base(context) { }
    }
}
