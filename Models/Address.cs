namespace Monday.Models
{
    public class Address : BaseModel
    {
        public string Street { get; set; }
        public string StreetComplement { get; set; }
        public string DoorNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Locale { get; set; }

    }
}
