using Microsoft.EntityFrameworkCore;
using Monday.Models;
using Monday.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.Repository.Implementation
{
    public class ProductListRepository : GenericRepository<ProductList>, IProductListRepository

    {
        protected readonly DbContext _context;

        public ProductListRepository(DbContextMonday context)
        : base(context) { }

        public async Task<ProductList> GetByIdIncluded(int id)
        {
            return await _context.Set<ProductList>()
                    .Include(x => x.Product)
                    .FirstOrDefaultAsync(e => e.Id == id);
        }

    }
}
