using System.Web;
using System.Web.Mvc;

namespace MVC_.NET_framwork_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
