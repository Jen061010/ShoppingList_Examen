using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class ServiceBase:IDisposable
    {
        readonly IUnitOfWork _unitOfWork;
        public ServiceBase(IUnitOfWork unitOfWork)
        {
            if (null == unitOfWork) 
            {
                throw new ArgumentNullException("unitOfWork");
            }
            _unitOfWork = unitOfWork;
        }

        private int SaveChanges()
        {
           return _unitOfWork.SaveChanges();
        }
        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}