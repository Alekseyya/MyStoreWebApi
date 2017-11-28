using System.Web;
using System.Web.Mvc;
using MyWebAPI.Api;

namespace MyStoreWebApi.Api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
