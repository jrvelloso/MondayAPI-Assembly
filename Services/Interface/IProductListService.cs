using Monday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.Services.Interface
{
    public interface IProductListService
    {
        Task<string> Create(ProductList productList);
        Task<string> Delete(int id);
        Task<List<ProductList>> GetAll();
        Task<ProductList> GetById(int id);
        Task<ProductList> GetByIdIncluded(int id);
        Task<string> Update(ProductList productList);
    }
}
