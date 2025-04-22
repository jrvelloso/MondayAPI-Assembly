//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class CheckoutService : ICheckoutService
    {
        private ICheckoutRepository _checkoutRepository;

        public CheckoutService(ICheckoutRepository checkoutRepository)
        {
            _checkoutRepository = checkoutRepository;
        }

        public async Task<Checkout> AddAsync(Checkout checkout)
        {
            await _checkoutRepository.AddAsync(checkout);
            await _checkoutRepository.SaveAsync();
            return checkout;
        }

        public async Task<Checkout?> GetByIdAsync(int id)
        {
            return await _checkoutRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Checkout>> GetAllAsync()
        {
            return await _checkoutRepository.GetAllAsync();
        }

        public async Task UpdateAsync(Checkout checkout)
        {
            _checkoutRepository.Update(checkout);
            await _checkoutRepository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var checkout = await GetByIdAsync(id);
            if (checkout != null)
            {
                _checkoutRepository.Delete(checkout);
                await _checkoutRepository.SaveAsync();
            }
        }

        public decimal CalculateTotalPrice(List<Product> products)
        {
            return products.Sum(product => product.Price * product.Amount);
        }
    }
}
