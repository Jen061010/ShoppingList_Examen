using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
   
    public class ServiceTicket : ServiceBase,IServiceTicket
    {
        readonly IRepositoryTicket _repositoryTicket;
        public ServiceTicket(IRepositoryTicket repositoryTicket, IUnitOfWork unitOfWork)
            :base(unitOfWork)
        {
            if (null == repositoryTicket) 
            {
                throw new ArgumentNullException("repositoryTicket");
            }

            _repositoryTicket = repositoryTicket;
            
        }
        public IEnumerable<Ticket> GetAlls(DateTime initialDate, DateTime finalDate)
        {
            return _repositoryTicket.GetAll(initialDate, finalDate);
        }
        public Ticket Add(Ticket ticket)
        {
            return _repositoryTicket.Add(ticket);
        }
        public Ticket Get(string id) 
        {
            var id_int = Convert.ToInt32(id);
            return _repositoryTicket.Get(id_int);
        }
    }
}
