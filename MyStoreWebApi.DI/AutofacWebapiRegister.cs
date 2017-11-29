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
        public static void RegisterWebApiServices(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>()
                .As<IUnitOfWork>();
            builder.RegisterType<CategoryService>()
                .As<ICategoryService>();
            builder.RegisterType<OrderService>()
                .As<IOrderService>();
            builder.RegisterType<ProductService>()
                .As<IProductService>();
            builder.RegisterType<UserService>()
                .As<IUserService>();
            builder.RegisterType<MarkService>()
                .As<IMarkService>();
        }
    }
}
