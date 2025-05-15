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

        public async Task<CheckoutProduct> GetById(int id)
        {
            CheckoutProduct checkoutProduct = await _checkoutProductRepository.GetByIdAsync(id);
            return checkoutProduct;
        }

        public async Task<CheckoutProduct> Add(CheckoutProduct checkoutProduct)
        {
            await _checkoutProductRepository.AddAsync(checkoutProduct);
            await _checkoutProductRepository.SaveAsync();
            return checkoutProduct;
        }
        public async Task<bool> Update(CheckoutProduct checkoutProduct)
        {
            var existingCheckoutProduct = await _checkoutProductRepository.GetByIdAsync(checkoutProduct.Id);

            if (existingCheckoutProduct == null)
                return false;

            _checkoutProductRepository.Update(checkoutProduct);
            await _checkoutProductRepository.SaveAsync();
            return true;
        }

        public async Task<bool> Delete(CheckoutProduct checkoutProduct)
        {
            var existingCheckoutProduct = await _checkoutProductRepository.GetByIdAsync(checkoutProduct.Id);

            if (existingCheckoutProduct == null)
                return false;

            _checkoutProductRepository.Delete(checkoutProduct);
            await _checkoutProductRepository.SaveAsync();
            return true;
        }


    }
}
