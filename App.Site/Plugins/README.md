### �����������

#### Լ���͹���

* ������Ʊ�����`Plugin`��β����`TestPlugin`��

*****

* �����Ŀ����������ѭ `App.�������Plugin`���磺`App.TestPlugin`

*****

* �����Ŀ���뽫����·�ɹ�����ڵ�һλ������`App_Start`Ŀ¼�е�`RouteConfig.cs` �������·�ɣ�����`pluginName`���ǲ�����ƣ�Ҳ�����`Plugin`��β���磺

```C#
// ������·��
routes.MapRoute(
    name: "PluginRoute",
    url: "{controller}/{action}/{pluginName}/{id}",
    defaults: new { controller = "Default", action = "Index", pluginName = "TestPlugin", id = UrlParameter.Optional },
    constraints: new { pluginName = @"^[0-9a-zA-Z]+Plugin$" }
);
```

#### ��װ���

* ����������֮�󣬱�������Ŀ���������Ŀ��Ӧ��`dll`����Դ�ļ���Script��Views��Content�����Ʒŵ� `App.Site`��Ŀ��`Plugins`Ŀ¼�£�ÿһ��������ж�Ӧ���ļ��У��磺

```
App.Site ��վ�ļ���
����Plugins ���Ŀ¼
|  ����TestPlugin ���1Ŀ¼
|  |  ����Libs ����DLL
|  |  ����Views ��ͼĿ¼
|  |  ����Scripts �ű�Ŀ¼
|  |  ����Content ��ʽĿ¼
|  |  ����Others ����Ŀ¼
|  ����TestPlugin2 ���2Ŀ¼
|  |  ����Libs ����DLL
|  |  ����Views ��ͼĿ¼
|  |  ����Scripts �ű�Ŀ¼
|  |  ����Content ��ʽĿ¼
|  |  ����Others ����Ŀ¼
|  ����TestPlugin3 ���3Ŀ¼
|  |  ����Libs ����DLL
|  |  ����Views ��ͼĿ¼
|  |  ����Scripts �ű�Ŀ¼
|  |  ����Content ��ʽĿ¼
|  |  ����Others ����Ŀ¼

```

#### ���ʲ��

��ʽ��`����/IP��ַ/����/������/Action/�������/����`���磺

```
http://www.winu.net/Default/Index/TestPlugin/

```