using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Mvc;
using Autofac;
using Autofac.Core;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using MyStoreWebApi.Api;
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
        public void Configuration(IAppBuilder app)
        {
            // Дополнительные сведения о настройке приложения см. по адресу: http://go.microsoft.com/fwlink/?LinkID=316888
            //HttpConfiguration config = new HttpConfiguration();
            //WebApiConfig.Register(config);
            //app.UseWebApi(config);
            ConfigureOAuth(app);
            


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
            var root = AutofacWebApiConfig.Container.ComponentRegistry.Registrations.FirstOrDefault
                                            (o=>o.Activator.LimitType.Name == "UserService");
            var temp = root.Services;
            

            IUserService single = null;
            using (var aa = AutofacWebApiConfig.Container.BeginLifetimeScope())
            {
                single = aa.Resolve<UserService>();
            }

            //var bb = ((IDependencyScope) AutofacWebApiConfig.Config.DependencyResolver).GetService(typeof(UserService));

            var userService = (IUserService)GlobalConfiguration.Configuration.DependencyResolver.GetService(typeof(UserService));
            //using (var a = GlobalConfiguration.Configuration.DependencyResolver.BeginScope())
            //{
            //    var aa = a.GetService<IUserService>(typeof(UserService));

            //    var bb = a.GetServices()
            //}
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AuthorizeEndpointPath = new PathString(""),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider(single)
                
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }
}
