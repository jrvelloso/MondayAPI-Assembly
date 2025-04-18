using Monday.Models;

namespace Monday.Services.Interface
{
    //ToDoMonday 
    namespace Monday.Services.Interface
    {
        public interface IPaymentMethodService
        {
            Task<string> Create(PaymentMethod paymentMethod);
            Task<string> Delete(int id);
            Task<List<PaymentMethod>> GetAll();
            Task<PaymentMethod> GetById(int id);
            Task<string> Update(PaymentMethod paymentMethod);
        }
    }
}