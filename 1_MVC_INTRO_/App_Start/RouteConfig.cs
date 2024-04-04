using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _1_MVC_INTRO_
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();//to enable attribute based routing  

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //first route
            routes.MapRoute(
                 name: "Default",
                 url: "{controller}/{action}/{id}",
                 defaults: new { controller = "Home", action = "Welcome", id = UrlParameter.Optional }
             );

            //second routing
            routes.MapRoute(
               name: "Default1",
               url: "{controller}/{action}/{id}/{name}"
           );
        }
    }
}
