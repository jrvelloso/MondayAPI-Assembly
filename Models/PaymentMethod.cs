namespace Monday.Models
{
    //ToDoMonday 
    // what are the proprieties for PaymentMethod object?
    // create all of them so we can create a new migration with it
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Provider { get; set; }
        public int CardNumber { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
    }
}
