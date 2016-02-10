using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Compilation;
using System.Web.Http;

/*!
 * 插件名称：Autofac 依赖注入，控制反转
 * 插件作者：新生帝
 * 编写日期：2016年02月10日
 * 版权所有：中山赢友网络科技有限公司
 * 企业官网：http://www.winu.net
 * 开源协议：GPL v2 License
 * 插件描述：一切从简，只为了更懒！
 */

namespace App.RESTful_API
{
    public static class Bootstrapper
    {
        public static void StartRegisterDependencies()
        {
            ContainerBuilder builder = new ContainerBuilder();
            var assemblys = BuildManager.GetReferencedAssemblies().Cast<Assembly>().ToList();

            builder.RegisterAssemblyTypes(assemblys.ToArray()).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(assemblys.ToArray()).Where(t => t.Name.EndsWith("Services")).AsImplementedInterfaces();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();

            var configuration = GlobalConfiguration.Configuration;

            configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}