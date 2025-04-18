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

        public async Task<List<PaymentMethod>> GetAll()
        {
            var all = await _paymentMethodRepository.GetAllAsync();
            return all.ToList();
        }
        public async Task<PaymentMethod> GetById(int id)
        {
            PaymentMethod paymentMethod = await _paymentMethodRepository.GetByIdAsync(id);
            return paymentMethod;
        }
        public async Task<string> Create(PaymentMethod paymentMethod)
        {
            await _paymentMethodRepository.AddAsync(paymentMethod);
            return "PaymentMethod created with success";
        }
        public async Task<string> Update(PaymentMethod paymentMethod)
        {
            PaymentMethod updatePaymentMethod = await _paymentMethodRepository.GetByIdAsync(paymentMethod.Id);
            if (updatePaymentMethod != null)
            {
                _paymentMethodRepository.Update(paymentMethod);
                return "PaymentMethod updated with success";
            }
            else
                return "PaymentMethod not found";
        }
        public async Task<string> Delete(int id)
        {
            PaymentMethod paymentMethod = await _paymentMethodRepository.GetByIdAsync(id);
            if (paymentMethod == null)
            {
                return "PaymentMethod not founded";
            }
            _paymentMethodRepository.Delete(paymentMethod);
            return "PaymentMethod removed with success";
        }
    }
}
