using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.Models
{
    public class CheckoutProduct : BaseModel
    {
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual Checkout Checkout { get; set; }
        public virtual Product Product { get; set; }

    }
}
