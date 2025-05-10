//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
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
    }
}
