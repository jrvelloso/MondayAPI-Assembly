using Microsoft.EntityFrameworkCore;
using Monday.Models;
using Monday.Repository.Interfaces;

namespace Monday.Repository.Implementation
{

    public class ProductRepository : GenericRepository<Product>, IProductRepository

    {
        protected readonly DbContext _context;

        public ProductRepository(DbContextMonday context)
           : base(context) { }

    }
}
