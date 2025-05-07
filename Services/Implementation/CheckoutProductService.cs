using Monday.Models;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class CheckoutProductService : ICheckoutProductService
    {
        private ICheckoutProductRepository _checkoutProductRepository;

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
        public async Task<string> Create(CheckoutProduct checkoutProduct)
        {
            await _checkoutProductRepository.AddAsync(checkoutProduct);
            int id = await _checkoutProductRepository.SaveAsync();
            return "CheckoutProduct created with success";
        }
        public async Task<string> Update(CheckoutProduct checkoutProduct)
        {
            CheckoutProduct updateCheckoutProduct = await _checkoutProductRepository.GetByIdAsync(checkoutProduct.Id);
            if (updateCheckoutProduct != null)
            {
                _checkoutProductRepository.Update(checkoutProduct);
                int id = await _checkoutProductRepository.SaveAsync();
                return "CheckoutProduct updated with success";
            }
            else
                return "CheckoutProduct not found";
        }
        public async Task<string> Delete(int id)
        {
            CheckoutProduct checkoutProduct = await _checkoutProductRepository.GetByIdAsync(id);
            if (checkoutProduct == null)
            {
                return "CheckoutProduct not founded";
            }
            _checkoutProductRepository.Delete(checkoutProduct);
            return "CheckoutProduct removed with success";
        }
    }
}
