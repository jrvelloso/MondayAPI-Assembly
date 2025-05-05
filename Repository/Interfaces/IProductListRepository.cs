using Monday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.Repository.Interfaces
{
    public interface IProductListRepository : IGenericRepository<ProductList>
    {
        Task<ProductList> GetByIdIncluded(int id);
    }
}
