using System.Web;
using System.Web.Mvc;

namespace FS.Tidebuy.CMS.Worker
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
