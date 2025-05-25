//ToDoMonday // Create CRUD methods: POST, PUT, GET AND DELETE
using Monday.Models;
using Monday.Repository.Interfaces;
using Monday.Services.Interface.Monday.Services.Interface;

namespace Monday.Services.Implementation
{
    public class PaymentMethodService : IPaymentMethodService
    {
        private IPaymentMethodRepository _paymentMethodRepository { get; set; }


        public PaymentMethodService(IPaymentMethodRepository paymentMethodRepository)
        {
            _paymentMethodRepository = paymentMethodRepository;
        }

        public async Task<IEnumerable<PaymentMethod>> GetAll()
        {
            var all = await _paymentMethodRepository.GetAllAsync();
            return all.ToList();
        }
        public async Task<PaymentMethod> GetById(int id)
        {
            PaymentMethod paymentMethod = await _paymentMethodRepository.GetByIdAsync(id);

            return paymentMethod;
        }
        public async Task<PaymentMethod> Create(PaymentMethod paymentMethod)
        {
            await _paymentMethodRepository.AddAsync(paymentMethod);
            await _paymentMethodRepository.SaveAsync();
            return paymentMethod;
        }
        public async Task<bool> Update(PaymentMethod paymentMethod)
        {
            var existingPaymentMethod = await _paymentMethodRepository.GetByIdAsync(paymentMethod.Id);

            if (existingPaymentMethod == null)
                return false;

            _paymentMethodRepository.Update(paymentMethod);
            await _paymentMethodRepository.SaveAsync();
            return true;
        }

        public async Task<bool> Delete(PaymentMethod paymentMethod)
        {
            var existingPaymentMethod = await _paymentMethodRepository.GetByIdAsync(paymentMethod.Id);

            if (existingPaymentMethod == null)
                return false;

            _paymentMethodRepository.Delete(paymentMethod);
            await _paymentMethodRepository.SaveAsync();
            return true;
        }
    }
}
