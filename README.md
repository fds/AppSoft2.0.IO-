## AppSoft2.0.IO不仅仅一个通用系统框架，更是你编程生涯的伴侣，可以让你编程效率有着事半功倍效果！

*****

> AppSoft2.0.IO 摒弃了Entity Framework，采用[SqlSugar](https://github.com/sunkaixuan/SqlSugar)框架，[SqlSugar](https://github.com/sunkaixuan/SqlSugar)是众多ORM框架中性能最接近ADO.NET的ORM框架！

*****

* 系统名称：AppSoft2.0.IO .NET通用开发系统
* 系统作者：新生帝
* 作者Q Q：8020292
* QQ交流群：18863883，一起改变中国IT教育！
* 开发日期：2016年02月09日
* 版权所有：中山赢友网络科技有限公司
* 企业官网：http://www.winu.net
* 开源协议：GPL v2 License
* 系统描述：一切从简，只为了更懒！

*****

### AppSoft2.0 IO 项目进度

* **目前项目已经搭建好基本骨架，任何Web系统都可以基于她上开发。**
* **内置功能会持续开发并更新中，欢迎关注！**

### AppSoft2.0 IO 系统设计及使用框架（持续更新）：

* 三层架构，抽象工厂，自动工厂，OOP，AOP
* **ASP.NET MVC 5/Web API2.1**
* **.NET Framework 4.6.1**
* Autofac 3.5.2
* [SqlSugar](https://github.com/sunkaixuan/SqlSugar)
* Redis
* Log4Net
* Quartz.Net
* Lucence.NET
* NPOI
* SuperSocket
* Senparc.Weixin.MP
* AutoMapper
* MSSQL 2005 + 

*****

### AppSoft2.0.IO 系统架构图：

![输入图片说明](http://git.oschina.net/uploads/images/2016/0212/023235_1173f9d3_526496.jpeg "在这里输入图片标题")

*****

### AppSoft2.0.IO 目录结构（待完善，持续更新）

```
AppSoft2.0.IO  解决方案目录
├─App.Document    项目说明文档，数据库初始化文件等等
├─App.Entity    数据表对应实体模型
├─App.Filter    MVC或Web API过滤器
├─App.IRepository    数据表对应仓储接口
├─App.IServices    数据表对应服务接口
├─App.Library    公共类库
├─App.ORM    ORM框架，如EF，SqlSugar
├─App.Repository    数据表对应仓储实例类
├─App.RESTful API    RESTful API接口项目
├─App.Services    数据表对应服务实例类
├─App.Site    网站项目
├─App.Vector    第三方提供DLL或者操作帮助类
├─App.WeiXin API	微信平台开发API接口
├─README.md	README文件
├─LICENSE.txt	授权说明文件

```

*****

### AppSoft2.0.IO 系统初始化步骤：

* 1.0 下载[http://git.oschina.net/winu.net/AppSoft2.0.IO/](AppSoft2.0.IO)

* 2.0 设置`App.RESTful API`（Web API）或`App.Site`（MVC + WebAPI）为项目启动项

* 3.0 设置2.0设置的启动项目的`Web.config`文件的`connectionStrings`节点的数据库链接字符串。

* 4.0 打开解决方案中`App.ORM`中`T4GenerateClient.tt`T4模板文件，设置`solutionDir`为你项目的绝对物理路径，以及`MssqlHelper.connStr`为数据库链接字符串

* 5.0 使用快捷键`Ctrl+S`或者点击工具栏`保存`按钮，保存`T4GenerateClient.tt`，T4模板文件会自动生成所有层的代码。

* 6.0 生成成功之后编辑器会提示`项目已被修改，是否重新加载`提示框，点击`全部重新加载`按钮即可。

* 7.0 右键`App.Repository`和`App.Services`项目，选择`属性`，点击左边的菜单`生成`，并设置`输出路径`为`..\App.RESTful API\bin\`或者`..\App.Site\bin\`，这里取决于你设置哪个项目为启动项（`App.RESTful API`或`App.Site`），这里主要是为了`Autofac`依赖注入和控制反转作用的。

* 8.0 加载完毕之后，点击`解决方案文件`，右键`重新生成解决方案`按钮，项目生成成功之后，整个项目初始化也就完成了！

*****

### AppSoft2.0.IO 项目实战代码：

* 1.0 在`App.RESTful API`或者`App.Site`项目`Controllers`文件夹下创建对应控制器（补充：`App.RESTful API`项目创建`Web API控制器`,`App.Site`项目创建`MVC控制器`）。

* 2.0 将新增的控制器继承`父控制器`（补充：`App.RESTful API`项目下的`Web API控制器`继承`BaseApiController`,`App.Site`项目下的`MVC控制器`继承`BaseController`）

* 3.0 在控制器中引入`using App.Entity;`和`using App.IServices;`命名空间。

* 4.0 编写控制器有参构造方法，将需要操作的服务接口声明为构造函数的形参，如：


```C#
// ApiDefaultController为上面新增控制器的名称，可以同时注入多个服务接口

public ApiDefaultController(IUserServices _IUserServices)
{
    base._IUserServices = _IUserServices;
}

```

* 5.0 可以调用接口对应的方法完成基本的CURD（增删改查）操作，甚至更复杂的操作，如：


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

### AppSoft2.0.IO 友情捐赠

如果你觉得 点点例 对你有价值，并且愿意让她继续成长下去，你可以资助这个项目的开发。

![友情捐赠AppSoft2.0.IO](http://git.oschina.net/uploads/images/2016/0207/160936_8f2d5f2e_526496.png "友情捐赠AppSoft2.0.IO")

*****

如果你喜欢AppSoft2.0.IO，可以点击右上角的`star`，想实时关注进度，可以点击右上角的`watch`。

最后，感谢每一个提建议和使用或者捐赠的朋友！因为你们，我们才能坚持！也是因为你们，未来才会更美好！