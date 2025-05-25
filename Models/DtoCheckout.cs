using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.Models
{
    public class CheckoutDto
    {
        public int EmployeeId { get; set; }
        public int PaymentMethodId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public List<ProductDto> ProductList { get; set; }

    }

}
