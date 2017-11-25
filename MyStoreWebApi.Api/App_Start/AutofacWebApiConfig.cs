using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using MyStoreWebApi.DI;

namespace MyWebAPI.Api.App_Start
{
    public class AutofacWebApiConfig
    {
        private static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            Container = AutofacWebApiRegister.RegisterServices(builder);
            config.DependencyResolver = new AutofacWebApiDependencyResolver(Container);
        }
    }
}