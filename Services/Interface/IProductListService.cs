using Monday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.Services.Interface
{
    internal interface IProductListService
    {
        Task<string> Create(CheckoutProduct productList);
        Task<string> Delete(int id);
        Task<List<CheckoutProduct>> GetAll();
        Task<CheckoutProduct> GetById(int id);
        Task<string> Update(CheckoutProduct productList);
    }
}
