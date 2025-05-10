using Monday.Models;
using Monday.Repository.Implementation;
using Monday.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.Services.Implementation
{
    public class CheckoutProductService
    {
        private ICheckoutProductRepository _checkoutProductRepository { get; set; }

        public CheckoutProductService(ICheckoutProductRepository checkoutProductRepository)
        {
            _checkoutProductRepository = checkoutProductRepository;
        }

        public async Task<List<CheckoutProduct>> GetAll()
        {
            var all = await _checkoutProductRepository.GetAllAsync();
            return all.ToList();
        }
    }
}
