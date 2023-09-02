using Autofac;
using Business.Abstract;
using Business.Concrete;
using Dataacces.Abstract;
using Dataacces.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.DependencyResolver.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UsersManager>().As<IUsersService>();
            builder.RegisterType<EfUsersDal>().As<IUsersDal>();
            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>();
            builder.RegisterType<OrderProductManager>().As<IOrderProductService>();
            builder.RegisterType<EfOrderProductDal>().As<IOrderProductDal>();
            builder.RegisterType<DeliveryManager>().As<IDeliveryService>();
            builder.RegisterType<EfDeliveryDal>().As<IDeliveryDal>();
        }
    }
}
