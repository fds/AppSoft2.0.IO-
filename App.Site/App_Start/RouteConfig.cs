using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace App.Site
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 定义插件路由
            routes.MapRoute(
               name: "PluginRoute",
               url: "{controller}/{action}/{pluginName}/{id}",
               defaults: new { controller = "Default", action = "Index", pluginName = "Plugin", id = UrlParameter.Optional },
               constraints: new { pluginName = @"^[0-9a-zA-Z]+Plugin$" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Index", id = UrlParameter.Optional, pluginName = "" }
            );
        }
    }
}
