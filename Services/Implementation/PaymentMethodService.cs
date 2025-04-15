//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Repository.Interfaces;
using Monday.Services.Interface.Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class PaymentMethodService : IPaymentMethodService
    {
        private IPaymentMethodRepository _productRepository { get; set; }


        public PaymentMethodService(IPaymentMethodRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<PaymentMethod>> GetAll()
        {
            var all = await _productRepository.GetAllAsync();
            return all.ToList();
        }
    }
}
