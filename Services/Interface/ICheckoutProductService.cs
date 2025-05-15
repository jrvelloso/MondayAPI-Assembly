using Monday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.Services.Interface
{
    public interface ICheckoutProductService
    {
        Task<List<CheckoutProduct>> GetAll();
        Task<CheckoutProduct> GetById(int id);
        Task<CheckoutProduct> Add(CheckoutProduct checkoutProduct);
        Task<CheckoutProduct> Update(CheckoutProduct checkoutProduct);
        Task<CheckoutProduct> Delete(int id);
    }
}
