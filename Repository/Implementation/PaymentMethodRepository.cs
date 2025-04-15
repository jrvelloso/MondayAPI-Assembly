using Microsoft.EntityFrameworkCore;
using Monday.Models;
using Monday.Repository.Interfaces;

namespace Monday.Repository.Implementation
{

    public class PaymentMethodRepository : GenericRepository<PaymentMethod>, IPaymentMethodRepository
    {
        protected readonly DbContext _context;

        public PaymentMethodRepository(DbContextMonday context)
           : base(context) { }
    }
}
