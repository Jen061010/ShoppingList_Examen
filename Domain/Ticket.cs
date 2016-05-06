using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ticket:EntityBase
    {
        public Ticket()
        {
            Details=new HashSet<Details>();
        }
        public DateTime Date { get; set; }
        public virtual IEnumerable<Details> Details { get; set; }

    }
}
