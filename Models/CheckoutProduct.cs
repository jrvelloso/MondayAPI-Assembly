namespace Monday.Models
{
    public class CheckoutProduct : BaseModel
    {
        public int Amount { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int ChekcoutId { get; set; }
        public Checkout Checkout { get; set; }

    }
}
