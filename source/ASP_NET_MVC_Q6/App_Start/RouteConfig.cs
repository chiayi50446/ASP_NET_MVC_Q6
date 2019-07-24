using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_NET_MVC_Q6
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home_Controller",
                url: "Contact",
                defaults: new { controller = "Home", action = "ContactMe"},
                constraints: new { controller = "Home", action = "ContactMe" },
                namespaces: new string[] { "ASP_NET_MVC_Q6.Controllers" }
            );

            routes.MapRoute(
                name: "Default_Controller",
                url: "{action}",
                defaults: new { controller = "Default", action = "Index" },
                constraints: new { controller = "Default" },
                namespaces: new string[] { "ASP_NET_MVC_Q6.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index"},
                namespaces: new string[] { "ASP_NET_MVC_Q6.Controllers" }
            );
        }
    }
}
