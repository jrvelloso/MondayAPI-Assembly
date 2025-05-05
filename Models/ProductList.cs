using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monday.Models
{
    public class ProductList : BaseModel
    {
        public int Amount { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
