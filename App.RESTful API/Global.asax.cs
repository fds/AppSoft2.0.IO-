using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace App.RESTful_API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // 依赖注入所有程序集
            Bootstrapper.StartRegisterDependencies();

            GlobalConfiguration.Configure(WebApiConfig.Register);
            // 设置默认将所有对象自动输出为Json格式
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
        }
    }
}
