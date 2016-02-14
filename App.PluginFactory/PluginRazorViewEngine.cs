using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.WebPages.Razor;

namespace App.PluginFactory
{
    public class PluginRazorViewEngine : RazorViewEngine
    {
        private string pluginName = string.Empty;
        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            // 获取插件名称
            pluginName = controllerContext.RouteData.Values["pluginName"].ToString();

            // 判断是否是插件，插件格式是：插件名称+Plugin字符串
            Regex pluginNameReg = new Regex("^[0-9a-zA-Z]+Plugin$");
            bool isPlugin = pluginNameReg.Match(pluginName).Success;

            string[] AreaViewLocationFormats = {
                   "~/Areas/{2}/Views/{1}/{0}.cshtml",
                    "~/Areas/{2}/Views/Shared/{1}/{0}.cshtml"
                };

            string[] ViewLocationFormats = {
                   "~/Views/{1}/{0}.cshtml",
                    "~/Views/Shared/{1}/{0}.cshtml"
             };

            // 如果是插件
            if (isPlugin)
            {
                AreaViewLocationFormats = new string[]{
                    "~/Plugins/" + pluginName + "/Areas/{2}/Views/{1}/{0}.cshtml",
                    "~/Plugins/" + pluginName + "/Areas/{2}/Views/Shared/{1}/{0}.cshtml"
                };
                ViewLocationFormats = new string[]{
                    "~/Plugins/" + pluginName + "/Views/{1}/{0}.cshtml",
                    "~/Plugins/" + pluginName + "/Views/Shared/{1}/{0}.cshtml"
                };

            }
            else
            {
                AreaViewLocationFormats = new string[]{
                    "~/Areas/{2}/Views/{1}/{0}.cshtml",
                    "~/Areas/{2}/Views/Shared/{1}/{0}.cshtml"
                };

                ViewLocationFormats = new string[]{
                    "~/Views/{1}/{0}.cshtml",
                    "~/Views/Shared/{1}/{0}.cshtml"
               };
            }

            // 将父类RazorViewEngine中的LocationFormats设置自定义的路径

            base.AreaPartialViewLocationFormats = AreaViewLocationFormats;
            base.AreaViewLocationFormats = AreaViewLocationFormats;
            base.AreaMasterLocationFormats = AreaViewLocationFormats;

            base.ViewLocationFormats = ViewLocationFormats;
            base.PartialViewLocationFormats = ViewLocationFormats;
            base.MasterLocationFormats = ViewLocationFormats;

            // 重写视图引擎将 视图编译成前台页面类的方法
            RazorBuildProvider.CodeGenerationStarted += RazorBuildProvider_CodeGenerationStarted;
            return base.FindView(controllerContext, viewName, masterName, useCache);
        }

        private void RazorBuildProvider_CodeGenerationStarted(object sender, EventArgs e)
        {
            RazorBuildProvider provider = sender as RazorBuildProvider;

            // 获取当前网站运行目录
            string sitePath = AppDomain.CurrentDomain.BaseDirectory;

            // 获取插件目录，默认放在Plugins文件夹下面
            string pluginsPath = sitePath + "Plugins";

            // 搜索插件下所有的dll程序集
            string[] pluginDLLs = Directory.GetFiles(pluginsPath, "App." + pluginName + ".dll", SearchOption.AllDirectories);

            // 将搜索到的dll载入当前运行程序集中
            if (pluginDLLs.Any())
            {
                foreach (string currentPluginDLL in pluginDLLs)
                {
                    Assembly ass = Assembly.LoadFile(currentPluginDLL);

                    //将ass 添加为视图前台页面类的引用程序集
                    provider.AssemblyBuilder.AddAssemblyReference(ass);
                }
            }
        }
    }
}
