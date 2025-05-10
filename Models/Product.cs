namespace Monday.Models
{
    //ToDoMonday 
    // new entity - this is not at the first migration
    // it looks good for now, but you can improve if you want
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

    }

}