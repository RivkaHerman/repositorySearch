
using System.Web.Mvc;
using System.Web.Routing;

namespace mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           

            routes.MapRoute(
               name: "Home",
               url: "Home/myHome",
               defaults: new { controller = "Home", action = "ShowHomePage", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              name: "Json",
              url: "Json",
              defaults: new { controller = "Home", action = "GetJsonDataModel", id = UrlParameter.Optional }
          );

            routes.MapRoute(
              name: "DefaultRoute",
              url: "",
              defaults: new { controller = "Home", action = "ShowHomePage", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
