using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    
    public class ServiceProduct : ServiceBase,IServiceProduct
    {
        readonly IServiceProduct _serviceProduct;
        readonly IUnitOfWork _unitOfWork;
        public ServiceProduct(IServiceProduct serviceProduct, IUnitOfWork unitOfWork)
            :base(unitOfWork)
        {
            if (null == serviceProduct) 
            {
                throw new ArgumentNullException("serviceProduct");
            }
            if (null == unitOfWork)
            {
                throw new ArgumentNullException("unitOfWork");
            }
            _serviceProduct = serviceProduct;
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Product> GetAlls()
        {
            return _serviceProduct.GetAlls();
        }
            
    }
}
