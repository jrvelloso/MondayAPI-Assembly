namespace Monday.Models
{
    //ToDoMonday 
    // what are the proprieties for PaymentMethod object?
    // create all of them so we can create a new migration with it
    public class PaymentMethod : BaseModel
    {
        public int ProductId { get; set; }
        public string Card { get; set; }
        public string MBWAY { get; set; } 
        public string IBAN { get; set; }
        public string MultibancoReference { get; set; }
        public string PayPal {  get; set; }
        public string ApplePay { get; set; }
        public string GooglePay { get; set; }
        public Product Product { get; set; }




    }
}
