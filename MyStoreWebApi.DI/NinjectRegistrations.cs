using Ninject;

namespace MyStoreWebApi.DI
{
    public class NinjectRegistrations
    {
        public static void RegisterServices(IKernel kernel)
        {
            //kernel.Bind<IClientService>().To<ClientService>();
            //kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
