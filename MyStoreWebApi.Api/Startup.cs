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

            //HttpConfiguration config = new HttpConfiguration();
            //WebApiConfig.Register(config);
            //app.UseWebApi(config);

            ConfigureOAuth(app);
            //app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            //app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            //    LoginPath = new PathString("/Account/Login"),
            //    Provider = new CookieAuthenticationProvider
            //    {
            //        OnValidateIdentity = SecurityStampValidator
            //            .OnValidateIdentity<ApplicationUserManager, ApplicationUser, Guid>(
            //                validateInterval: TimeSpan.FromMinutes(30),
            //                regenerateIdentityCallback: (manager, user) =>
            //                    user.GenerateUserIdentityAsync(manager),
            //                getUserIdCallback: (id) => (id.GetUserId<Guid>()))
            //    }
            //});
        }
        public void ConfigureOAuth(IAppBuilder app)
        {
            //var root = AutofacWebApiConfig.Container.ComponentRegistry.Registrations.FirstOrDefault
                                            //(o=>o.Activator.LimitType.Name == "UserService");
            //var temp = root.Services;

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
