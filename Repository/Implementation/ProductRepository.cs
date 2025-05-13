using Monday.Models;
using Monday.Repository.Interfaces;

namespace Monday.Repository.Implementation
{

    public class ProductRepository : GenericRepository<Product>, IProductRepository

    {
        public ProductRepository(DbContextMonday context)
           : base(context) { }
    }
}
