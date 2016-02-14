using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using App.PluginFactory;

namespace App.Site
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // 开始注入
            Bootstrapper.StartRegisterDependencies();

            // 在应用程序启动时运行的代码
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // 重写默认控制器工厂为插件控制器工厂
            ControllerBuilder.Current.SetControllerFactory(new PluginControllerFactory());

            //移除当前MVC主站点中的所有视图引擎，采用自定义视图引擎
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new PluginRazorViewEngine());
        }
    }
}