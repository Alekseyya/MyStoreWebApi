using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Core;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using MyStoreWebApi.Api;
using MyStoreWebApi.Api.App_Start;
using MyStoreWebApi.BL.Services;
using MyStoreWebApi.BL.Services.Interfaces;
using MyStoreWebApi.DI;
using MyWebAPI.Api.App_Start;
using MyWebAPI.Api.Models;
using MyWebAPI.Api.Providers;
using Owin;

[assembly: OwinStartup(typeof(MyWebAPI.Api.Startup))]

namespace MyWebAPI.Api
{
    public class Startup
    {
        public static IContainer Container;
        public void Configuration(IAppBuilder app)
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Container =  AutofacWebApiConfig.Initialize();

            AutoMapperApiConfiguration.Configure();
            
            //app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            ConfigureOAuth(app);

        }
        public void ConfigureOAuth(IAppBuilder app)
        {
            //create singleton
            var userService = Container.Resolve<IUserService>();
            
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider(userService)

            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }
}
