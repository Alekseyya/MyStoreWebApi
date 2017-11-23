using MyStoreWebApi.BL.Services;
using MyStoreWebApi.BL.Services.Interfaces;
using MyStoreWebApi.DAL.Repositories;
using MyStoreWebApi.DAL.Repositories.Base;
using Ninject;

namespace MyStoreWebApi.DI
{
    public class NinjectRegistrations
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
            kernel.Bind<ICategoryService>().To<CategoryService>();
            kernel.Bind<IOrderService>().To<OrderService>();
            kernel.Bind<IProductService>().To<ProductService>();
            kernel.Bind<IUserService>().To<UserService>();
        }
    }
}
