using Monday.Models;

namespace Monday.Services.Interface
{
    //ToDoMonday 
    namespace Monday.Services.Interface
    {
        public interface IPaymentMethodService
        {
            Task<List<PaymentMethod>> GetAll();
            Task<PaymentMethod?> GetById(object id);
            Task Create(PaymentMethod paymentMethod);
            Task Update(PaymentMethod paymentMethod);
            Task Delete(PaymentMethod paymentMethod);
        }
    }
}