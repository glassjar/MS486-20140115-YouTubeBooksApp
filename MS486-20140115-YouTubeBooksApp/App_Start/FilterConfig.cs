using System.Web;
using System.Web.Mvc;

namespace MS486_20140115_YouTubeBooksApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}