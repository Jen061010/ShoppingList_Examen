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
        readonly IRepositoryProduct _repositoryProduct;
        public ServiceProduct(IRepositoryProduct repositoryProduct, IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            if (null == repositoryProduct)
            {
                throw new ArgumentNullException("repositoryProduct");
            }

            _repositoryProduct = repositoryProduct;
        }
        public IEnumerable<Product> GetAlls()
        {
            return _repositoryProduct.GetAll();
        }
            
    }
}
