using Microsoft.EntityFrameworkCore;
using Monday.Models;
using Monday.Repository.Interfaces;

namespace Monday.Repository.Implementation
{

    public class CheckoutRepository : GenericRepository<Checkout>, ICheckoutRepository
    {
        protected readonly DbContext _context;

        public CheckoutRepository(DbContextMonday context)
           : base(context) { }

        public async Task<Checkout> GetByIdIncluded(int id)
        {
            return await _context.Set<Checkout>()
                 .Include(x => x.Employee)
                 .Include(x => x.PaymentMethod)
                 .FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}
