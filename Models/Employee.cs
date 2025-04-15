namespace Monday.Models
{
    public class Employee : BaseModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } //ToDoMonday // new field - this is not at the first migration
        public string Phone { get; set; }
        public bool AcceptedRGDPT { get; set; }
        public string NIF { get; set; }
        public string NIB { get; set; }
        public bool NeedsNDA { get; set; }
        public int JobId { get; set; }
        public int AddressId { get; set; }
        public virtual Job Job { get; set; }
        public virtual Address Address { get; set; }
    }
}
