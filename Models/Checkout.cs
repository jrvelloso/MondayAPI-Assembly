namespace Monday.Models
{
    //ToDoMonday 
    // new entity - this is not at the first migration
    // it looks good for now, but you can improve if you want
    public class Checkout : BaseModel
    {
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int PaymentMethodId { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual List<Product> Products { get; set; }
        public DateTime Date { get; set; }
        public double TotalPrice { get; set; }
    }
}
