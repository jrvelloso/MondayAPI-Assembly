namespace Monday.Models.Dtos
{
    public class CheckoutDto
    {
        public int EmployeeId { get; set; }
        public int PaymentMethodId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CheckoutDate { get; set; } // Date of checkout
        public bool IsSuccessful { get; set; } // Status of the transaction
        public List<ProductDto> ProductList { get; set; }

    }
}
