using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace FOA_ASP_MVC
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/FOA/{action}/{id}",
                defaults: new { controller = "FOA_API_", id = RouteParameter.Optional }
            );
        }
    }
}
