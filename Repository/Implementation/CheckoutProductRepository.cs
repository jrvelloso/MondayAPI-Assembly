using Microsoft.EntityFrameworkCore;
using Monday.Repository.Interfaces;
using Monday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.Repository.Implementation
{
    public class CheckoutProductRepository : GenericRepository<CheckoutProduct>, ICheckoutProductRepository
    {
        protected readonly DbContext _context;

        public CheckoutProductRepository(DbContextMonday context)
           : base(context) { }
    }
}
