using Autofac;
using Autofac.Integration.Wcf;
using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebService
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();

            // Register your service implementations.
            builder.RegisterType<UsersContext>().As<IDbContext>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<RepositoryTicket>().As<IRepositoryTicket>();
            builder.RegisterType<WebService.ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<WebService.ServiceTicket>().As<IServiceTicket>();

            // Set the dependency resolver.
            var container = builder.Build();
            AutofacHostFactory.Container = container;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}