using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebService;

namespace IntegrationTest
{
    [TestClass]
    public class IntegrationTest

    {
        private readonly int Product = 4;
        private ServiceProduct _serviceProduct;

        [TestInitialize]
        public void SetUp()
        {
           _serviceProduct = new ServiceProduct();
            using(var ctx=new RepositoryProduct()){
                if (ctx.Database.Exists())
                    ctx.Database.Delete();
                ctx.Database.Create();
            }
        }

        [TestMethod]
        public void Test_GetAll_Product()
        {
           
        }
       
            
        
    }
}
