using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EPortal
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //attribute routing
            routes.MapMvcAttributeRoutes();


            //conventional routing
            routes.MapRoute(
                name: "Edit",
                url: "{controller}/{action}/{empid}"
            //defaults: new { controller = "Employee", action = "Edit" }
            );


            routes.MapRoute(
                name: "Details",
                url: "Employee/Details/{empid}/{name}",
                defaults: new { controller = "Employee", action = "Details" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employee", action = "Show", id = UrlParameter.Optional }
            );
        }
    }
}
