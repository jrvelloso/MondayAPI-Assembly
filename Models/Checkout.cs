namespace Monday.Models
{
    //ToDoMonday 
    // new entity - this is not at the first migration
    // it looks good for now, but you can improve if you want
    public class Checkout : BaseModel
    {
        public int EmployeeId { get; set; } 
        public int PaymentMethodId { get; set; } 
        public decimal TotalPrice { get; set; }
        public DateTime CheckoutDate { get; set; } // Date of checkout
        public bool IsSuccessful { get; set; } // Status of the transaction
        public virtual Employee Employee { get; set; } 
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual List<ProductList> ProductList { get; set; }

    }
}
