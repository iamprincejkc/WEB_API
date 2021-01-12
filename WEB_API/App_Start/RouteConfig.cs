using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WEB_API
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               "Test",                                           // Route name
               "Test/{action}/{id}",                            // URL with parameters
               new { controller = "Test", action = "Index", id = UrlParameter.Optional }
               );

            routes.MapRoute(
                "User",
                "User/{action}/{id}",
               new { controller = "User", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Test", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}