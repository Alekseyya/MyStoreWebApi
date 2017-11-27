using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MyStoreWebApi.Api.App_Start;
using MyStoreWebApi.BL.MapperConfig;
using MyStoreWebApi.BL.Services;
using MyStoreWebApi.BL.Services.Interfaces;
using MyStoreWebApi.DI;
using MyWebAPI.Api.App_Start;

namespace MyStoreWebApi.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutofacWebApiConfig.Initialize(GlobalConfiguration.Configuration);

            
            //var userService = (IUserService)GlobalConfiguration.Configuration.DependencyResolver.GetService(typeof(UserService));

            AutoMapperApiConfiguration.Configure();
            

            //AutoMapperServiceConfiguration.Configure();

            //NinjectModule registrations = new NinjectRegistrations();
            //var kernel = new StandardKernel(registrations);
            //GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
        }
    }
}
