using FS.Common.Filter;
using System.Web;
using System.Web.Mvc;

namespace FS.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new Log4NetExceptionFilter());
        }
    }
}
