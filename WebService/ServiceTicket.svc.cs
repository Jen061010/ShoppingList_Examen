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
        readonly IServiceTicket _serviceTicket;
        readonly IUnitOfWork _unitOfWork;
        public ServiceTicket(IServiceTicket serviceTicket, IUnitOfWork unitOfWork)
            :base(unitOfWork)
        {
            if (null == serviceTicket) 
            {
                throw new ArgumentNullException("serviceTicket");
            }
            if (null == unitOfWork)
            {
                throw new ArgumentNullException("unitOfWork");
            }
            _serviceTicket = serviceTicket;
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Ticket> GetAlls(DateTime initialDate, DateTime finalDate)
        {
            return _serviceTicket.GetAlls( initialDate,finalDate);
        }
        public Ticket Add(Ticket ticket)
        {
            return _serviceTicket.Add(ticket);
        }
        public Ticket Get(string id) 
        {
            return _serviceTicket.Get(id);
        }
    }
}
