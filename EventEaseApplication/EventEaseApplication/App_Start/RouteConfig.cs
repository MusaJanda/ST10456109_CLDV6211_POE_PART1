using System.Web.Mvc;
using System.Web.Routing;

namespace EventEaseApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Default route set to HomeController
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Venue", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
