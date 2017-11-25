using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using MyStoreWebApi.BL.Services;
using MyStoreWebApi.BL.Services.Interfaces;
using MyStoreWebApi.DAL.Repositories;
using MyStoreWebApi.DAL.Repositories.Base;

namespace MyStoreWebApi.DI
{
    public class AutofacWebApiRegister
    {
        public static IContainer RegisterServices(ContainerBuilder builder)
        {
            
            builder.RegisterType<UnitOfWork>()
                .As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<CategoryService>()
                .As<ICategoryService>().InstancePerRequest();
            builder.RegisterType<OrderService>()
                .As<IOrderService>().InstancePerRequest();
            builder.RegisterType<ProductService>()
                .As<IProductService>().InstancePerRequest();
            builder.RegisterType<UserService>()
                .As<IUserService>().InstancePerRequest();

            //Set the dependency resolver to be Autofac.  
            return builder.Build();
        }
    }
}
