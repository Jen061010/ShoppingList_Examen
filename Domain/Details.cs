using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Details:EntityBase
    {
        public  decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Product Product { get; set; }
    }
}
