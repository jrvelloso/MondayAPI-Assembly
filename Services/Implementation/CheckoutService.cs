//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Repository.Implementation;
using Monday.Repository.Interfaces;
using Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class CheckoutService : ICheckoutService
    {
        private ICheckoutRepository _checkoutRepository { get; set; }


        public CheckoutService(ICheckoutRepository checkoutRepository)
        {
            _checkoutRepository = checkoutRepository;
        }

        public async Task<List<Checkout>> GetAll()
        {
            var all = await _checkoutRepository.GetAllAsync();
            return all.ToList();
        }

        public async Task<Checkout> GetById(int id)
        {
            Checkout checkout = await _checkoutRepository.GetByIdAsync(id);
            return checkout;
        }

        public async Task<Checkout> Create(Checkout checkout)
        {
            await _checkoutRepository.AddAsync(checkout);
            await _checkoutRepository.SaveAsync();
            return checkout;
        }
        public async Task<bool> Update(Checkout checkout)
        {
            var existingCheckout = await _checkoutRepository.GetByIdAsync(checkout.Id);

            if (existingCheckout == null)
                return false;

            _checkoutRepository.Update(checkout);
            await _checkoutRepository.SaveAsync();
            return true;
        }

        public async Task<bool> Delete(Checkout checkout)
        {
            var existingCheckout = await _checkoutRepository.GetByIdAsync(checkout.Id);

            if (existingCheckout == null)
                return false;

            _checkoutRepository.Delete(checkout);
            await _checkoutRepository.SaveAsync();
            return true;
        }
    }
}
