namespace Monday.Models
{
    //ToDoMonday 
    // new entity - this is not at the first migration
    // it looks good for now, but you can improve if you want
    public class Checkout : BaseModel
    {
        public int AddressId { get; set; }
        public int ProductId { get; set; }
        public int PaymentMethodId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CheckoutTime { get; set; }
        public Address Address { get; set; }
        public List<Product> ProductList { get; set; }
        public PaymentMethod PaymentMethod { get; set; }


    }
}
