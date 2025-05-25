using Monday.Models;

namespace Monday.Services.Interface
{
    //ToDoMonday 
    namespace Monday.Services.Interface
    {
        public interface IPaymentMethodService
        {
            Task<IEnumerable<PaymentMethod>> GetAll();
            Task<PaymentMethod> GetById(int id);
            Task<PaymentMethod> Create(PaymentMethod paymentMethod);
            Task<bool> Update(PaymentMethod paymentMethod);
            Task<bool> Delete(PaymentMethod paymentMethod);
        }
    }
}