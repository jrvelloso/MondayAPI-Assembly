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

      

    }
}
