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
        Task<IEnumerable<CheckoutProduct>> GetAll();
        Task<CheckoutProduct> GetById(int id);
        Task<CheckoutProduct> Create(CheckoutProduct checkoutProduct);
        Task<bool> Update(CheckoutProduct checkoutProduct);
        Task<bool> Delete(CheckoutProduct checkoutProduct);
    }
}
