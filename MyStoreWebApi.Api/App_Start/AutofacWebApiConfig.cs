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
        public static IContainer Initialize()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterWebApiFilterProvider(config);

            builder.RegisterWebApiModelBinderProvider();

            AutofacWebApiRegister.RegisterWebApiServices(builder);

            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            return container;
        }
    }
}