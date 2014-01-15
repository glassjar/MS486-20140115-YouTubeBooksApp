using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MS486_20140115_YouTubeBooksApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
