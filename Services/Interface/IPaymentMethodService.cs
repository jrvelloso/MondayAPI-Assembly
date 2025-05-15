using Monday.Models;

namespace Monday.Services.Interface
{
    //ToDoMonday 
    namespace Monday.Services.Interface
    {
        public interface IPaymentMethodService
        {
            Task<List<PaymentMethod>> GetAll();
            Task<PaymentMethod> GetById(int id);
            Task<PaymentMethod> Add(PaymentMethod paymentMethod);
            Task<bool> Update(PaymentMethod paymentMethod);
            Task<bool> Delete(PaymentMethod paymentMethod);
        }
    }
}