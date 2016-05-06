using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class RepositoryTicket:RepositoryBase<Ticket>,IRepositoryTicket
    {
        public RepositoryTicket(IDbContext context)
            :base(context)
        {

        }

        public IEnumerable<Ticket> GetAll(DateTime initialDate, DateTime finalDate) 
        {
            return Entity.Where(c=>c.Date >= initialDate && c.Date<=finalDate);
        }

        public Ticket Add(Ticket ticket) 
        {
            return Entity.Add(ticket);        
        }

        public Ticket Get(int id)
        {
            return Entity.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
