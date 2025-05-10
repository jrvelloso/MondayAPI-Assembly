namespace Monday.Models
{
    //ToDoMonday 
    // new entity - this is not at the first migration
    // it looks good for now, but you can improve if you want
    public class Checkout
    {
        public int EmployeeId { get; set; }
        public int PaymentMethodId { get; set; }
        public int CheckoutId { get; set; }
        public DateTime PurchaseDate { get; set; }

    }
}
