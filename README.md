### AppSoft2.0.IO不仅仅一个通用系统框架，更是你编程生涯的伴侣，可以让你编程效率有着事半功倍效果！

*****

> AppSoft2.0.IO 摒弃了Entity Framework，采用[SqlSugar](https://github.com/sunkaixuan/SqlSugar)框架，[SqlSugar](https://github.com/sunkaixuan/SqlSugar)是众多ORM框架中性能最接近ADO.NET的ORM框架！

*****

### AppSoft2.0 IO 开发者信息

*****

* 系统名称：`AppSoft2.0.IO .NET通用开发系统`
* 系统作者：`新生帝`
* 作者Q Q：`8020292`
* QQ交流群：`18863883`，加群请注明：`AppSoft2.0.IO`
* 开发日期：`2016年02月09日`
* 版权所有：`中山赢友网络科技有限公司`
* 企业官网：[http://www.winu.net](http://www.winu.net)
* 开源协议：`GPL v2 License`
* 系统描述：`一切从简，只为了更懒！`

*****

### AppSoft2.0 IO 主要特点：

*****

后续更新！

*****

### AppSoft2.0 IO 项目进度

*****

* 目前项目未完成，只搭建好基本骨架！
* 内置功能会持续开发并更新中，欢迎关注！

*****

### AppSoft2.0 IO 系统设计及技术框架（持续更新）：

*****

#### 后端

* N层架构（抽象工厂，自动工厂，OOP，AOP）
* **ASP.NET MVC 5/Web API2.1**
* **.NET Framework 4.6.1**
* **MVC 插件式开发，支持热拔插**
* Autofac 3.5.2
* [SqlSugar](https://github.com/sunkaixuan/SqlSugar) | [文档说明](http://www.cnblogs.com/sunkaixuan/p/4649904.html)
* Redis
* Log4Net
* Quartz.Net
* Lucence.NET
* NPOI
* SuperSocket
* Senparc.Weixin.MP
* AutoMapper
* i18n
* RBAC
* WorkFlow
* nVelocity
* SQL Server 2005 + 

*****

#### 前端

整理中...

*****

### AppSoft2.0.IO 系统架构设计图：

*****

![输入图片说明](http://git.oschina.net/uploads/images/2016/0212/023235_1173f9d3_526496.jpeg "在这里输入图片标题")

*****

### AppSoft2.0.IO 目录结构（待完善，持续更新）

*****

```
AppSoft2.0.IO  解决方案目录
├─App.Document    项目说明文档，数据库初始化文件等等
├─App.Entity    数据表对应实体模型
├─App.IRepository    数据表对应仓储接口
├─App.IServices    数据表对应服务接口
├─App.Library    常用公共类库
├─App.ORM    ORM框架类库，如EF，SqlSugar
├─App.App.PluginFactory    插件管理器，实现插件机制
├─App.Repository    数据表对应仓储实例类
├─App.RESTful API    RESTful API接口项目
├─App.Services    数据表对应服务实例类
├─App.Site    网站项目
├─App.TestPlugin    测试插件示例
├─App.Vector    第三方提供DLL或者操作帮助类
├─App.WeiXin API	微信平台开发API接口
├─README.md	README文件
├─LICENSE.txt	授权说明文件

```

*****

### AppSoft2.0.IO 最终完成版目标包含以下子系统或功能，可以以插件形式自由添加子系统或功能：

*****

* CMS 内容管理系统（可以管理多个子站）
* 通用权限管理系统
* 企业OA系统（包含工作流，自定义表单）
* 微型CRM系统
* 即时通讯
* 工单系统
* 任务管理系统
* 微信平台管理系统
* 微型论坛社区系统
* 电商系统（产品，订单）
* 开放平台RESTfull API接口

*****

### AppSoft2.0.IO 系统初始化步骤：

*****

* 下载 [AppSoft2.0.IO]([http://git.oschina.net/winu.net/AppSoft2.0.IO/](AppSoft2.0.IO))

*****

* AppSoft2.0.IO是使用Visual Studio 2015编写的，意在开发适应未来的系统框架，支持Visual Studio 2012以上（包括）软件打开。

*****

* 打开`AppSoft2.0.IO.sln`解决方案后，设置`App.RESTful API`（Web API）或`App.Site`（MVC + WebAPI）为项目启动项，取决你是做Web开发或者Api接口开发。

*****

* 设置的上述设置的启动项目中的`Web.config`文件`connectionStrings`节点为数据库链接字符串。

*****

* 打开解决方案中`App.ORM`中`T4GenerateClient.tt`T4模板文件，设置`solutionDir`为你解决方案的绝对物理路径，以及`MssqlHelper.connStr`为数据库链接字符串，还可以设置`MssqlHelper.prefix`来设置表前缀，支持一个数据库多个系统开发。

*****

* 使用快捷键`Ctrl+S`或者点击工具栏`保存`按钮，保存`T4GenerateClient.tt`文件，这时T4模板文件会自动生成所有层的代码，一般数据库表结构发生改变都应该执行保存一次。

*****

* 生成成功之后编辑器会提示`项目已被修改，是否重新加载`提示框，点击`全部重新加载`按钮即可，项目会自动生成所需文件和自动包含指定文件到指定目录。

*****

* 右键`App.Repository`和`App.Services`项目，选择`属性`，点击左边的菜单`生成`，并设置`输出路径`为`..\App.RESTful API\bin\`或者`..\App.Site\bin\`，这里取决于你设置哪个项目为启动项（`App.RESTful API`或`App.Site`），这里主要是为了`Autofac`依赖注入和控制反转作用的。

*****

* 加载完毕之后，右击`解决方案文件`，选择`重新生成解决方案`按钮，项目重新生成成功之后，整个项目初始化也就完成了！

*****

### AppSoft2.0.IO 项目实战代码：

*****

* 在`App.RESTful API`或者`App.Site`项目`Controllers`文件夹下创建对应控制器（补充：`App.RESTful API`项目创建`Web API控制器`,`App.Site`项目创建`MVC控制器`）。

*****

* 将新增的控制器继承`父控制器`（补充：`App.RESTful API`项目下的`Web API控制器应`继承`BaseApiController`,`App.Site`项目下的`MVC控制器`应继承`BaseController`）

*****

* 在控制器中头部引入`App.Entity;`和`App.IServices;`命名空间。

*****

* 编写控制器有参构造方法，将需要操作的服务接口声明为构造函数的形参，主要作用是项目启动时，Autofac会向控制器构造方法注入服务和仓储实例对象，如：


```C#
// ApiDefaultController为上面新增控制器的名称，可以同时注入多个服务接口

public ApiDefaultController(IUserServices _IUserServices)
{
    base._IUserServices = _IUserServices;
}

```

*****

* 可以调用接口对应的方法完成基本的CURD（增改查删）操作，甚至更复杂的操作，如：


```C#
// 新增操作

_IUserServices.Insert(new UserEntity(){
    UserName='新生帝'
});

// 更新操作

...

// 删除操作

...

// 查询操作

...

```

*****

### AppSoft2.0.IO 应用场景（持续更新）：

*****

* Web软件系统开发
* 企业/门户网站开发
* 管理系统开发
* 电商平台开发
* 微信平台开发
* 论坛社区开发
* ...
* ...
* ...

*****

### AppSoft2.0.IO 欢迎捐赠

*****

如果你觉得 AppSoft2.0.IO 对你有价值，并且愿意让她继续成长下去，你可以资助这个项目的开发，为作者加油打气。

![欢迎捐赠AppSoft2.0.IO](http://git.oschina.net/uploads/images/2016/0207/160936_8f2d5f2e_526496.png "欢迎捐赠AppSoft2.0.IO")

*****

如果你喜欢AppSoft2.0.IO，可以点击右上角的`star`，想实时关注进度，可以点击右上角的`watch`。

最后，感谢每一个提建议和使用或者捐赠的朋友！因为你们，我们才能坚持！也是因为你们，未来才会更美好！