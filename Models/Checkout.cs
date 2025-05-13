using System.Runtime.CompilerServices;

namespace Monday.Models
{
    //ToDoMonday 
    // new entity - this is not at the first migration
    // it looks good for now, but you can improve if you want
    public class Checkout : BaseModel
    {
        public int EmployeeId { get; set; }
        public int PaymentMethodId { get; set; }
        public int CheckoutId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
