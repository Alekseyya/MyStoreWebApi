using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using MyStoreWebApi.Api;
using Owin;

[assembly: OwinStartup(typeof(MyWebAPI.Api.Startup))]

namespace MyWebAPI.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Дополнительные сведения о настройке приложения см. по адресу: http://go.microsoft.com/fwlink/?LinkID=316888
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
