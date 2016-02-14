### 插件开发步骤

#### 约定和规则

* 插件名称必须以`Plugin`结尾，如`TestPlugin`。

*****

* 插件项目命名必须遵循 `App.插件名称Plugin`，如：`App.TestPlugin`

*****

* 插件项目必须将下面路由规则放在第一位，如在`App_Start`目录中的`RouteConfig.cs` 添加下面路由，其中`pluginName`就是插件名称，也必须带`Plugin`结尾，如：

```C#
// 定义插件路由
routes.MapRoute(
    name: "PluginRoute",
    url: "{controller}/{action}/{pluginName}/{id}",
    defaults: new { controller = "Default", action = "Index", pluginName = "TestPlugin", id = UrlParameter.Optional },
    constraints: new { pluginName = @"^[0-9a-zA-Z]+Plugin$" }
);
```

#### 安装插件

* 插件开发完成之后，编译插件项目，将插件项目对应的`dll`和资源文件（Script，Views，Content）复制放到 `App.Site`项目的`Plugins`目录下，每一个插件都有对应的文件夹，如：

```
App.Site 主站文件夹
├─Plugins 插件目录
|  ├─TestPlugin 插件1目录
|  |  ├─Libs 程序集DLL
|  |  ├─Views 视图目录
|  |  ├─Scripts 脚本目录
|  |  ├─Content 样式目录
|  |  ├─Others 其他目录
|  ├─TestPlugin2 插件2目录
|  |  ├─Libs 程序集DLL
|  |  ├─Views 视图目录
|  |  ├─Scripts 脚本目录
|  |  ├─Content 样式目录
|  |  ├─Others 其他目录
|  ├─TestPlugin3 插件3目录
|  |  ├─Libs 程序集DLL
|  |  ├─Views 视图目录
|  |  ├─Scripts 脚本目录
|  |  ├─Content 样式目录
|  |  ├─Others 其他目录

```

#### 访问插件

格式：`域名/IP地址/区域/控制器/Action/插件名称/参数`，如：

```
http://www.winu.net/Default/Index/TestPlugin/

```