namespace Monday.Models
{
    //ToDoMonday 
    // what are the proprieties for PaymentMethod object?
    // create all of them so we can create a new migration with it
    public class PaymentMethod : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
