
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
               url: "home/myHome",
               defaults: new { controller = "Home", action = "ShowHomePage", id = UrlParameter.Optional }
           );
          
            routes.MapRoute(
              name: "Display",
              url: "displayBookmarks",
              defaults: new { controller = "Bookmarks", action = "DisplayBookmarks", id = UrlParameter.Optional }
          );

            routes.MapRoute(
              name: "Json",
              url: "Json",
              defaults: new { controller = "Repositories", action = "GetJsonDataModel", id = UrlParameter.Optional }
          );

            routes.MapRoute(
             name: "SearchForRepository",
             url: "repositories/searchForRepository",
             defaults: new { controller = "Repositories", action = "GetJsonDataModel", id = UrlParameter.Optional }
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
