using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.Owin.Security.OAuth;
using MyStoreWebApi.BL.Services;
using MyStoreWebApi.DI;
using MyWebAPI.Api.Providers;

namespace MyWebAPI.Api.App_Start
{
    public class AutofacWebApiConfig
    {
        public static IContainer Container;

        public static HttpConfiguration Config;
        public static void Initialize(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            Container = AutofacWebApiRegister.RegisterServices(builder);
            config.DependencyResolver = new AutofacWebApiDependencyResolver(Container);
            Config = config;
        }
    }
}