namespace Monday.Models
{
    public class CheckoutProduct : BaseModel
    {
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public int CheckoutId { get; set; }
        public Product Product { get; set; }
        public Checkout Checkout { get; set; }

    }
}
