using System;
using App.Entity;

using App.IRepository;
/*!
* 文件名称：CustomRepository仓储类
* 文件作者：新生帝
* 编写日期：2016-02-10 22:28:32
* 版权所有：中山赢友网络科技有限公司
* 企业官网：http://www.winu.net
* 开源协议：GPL v2 License
* 文件描述：一切从简，只为了更懒！
*/
namespace App.Repository
{
	public partial class CustomRepository : BaseRepository<CustomModel> , ICustomRepository
	{
	}
}