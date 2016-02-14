using System.Web.Http;
using App.IServices;

/*!
* 文件名称：BaseApiController父API控制器类
* 文件作者：新生帝
* 编写日期：2016-02-14 21:55:57
* 版权所有：中山赢友网络科技有限公司
* 企业官网：http://www.winu.net
* 开源协议：GPL v2 License
* 文件描述：一切从简，只为了更懒！
*/
namespace App.RESTful_API
{
	public partial class BaseApiController : ApiController
	{
		protected IUserServices _IUserServices;
	}
}