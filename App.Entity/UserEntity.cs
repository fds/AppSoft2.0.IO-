using System;
using System.Runtime.Serialization;

/*!
* 文件名称：UserEntity实体类
* 文件作者：新生帝
* 编写日期：2016-02-16 13:51:08
* 版权所有：中山赢友网络科技有限公司
* 企业官网：http://www.winu.net
* 开源协议：GPL v2 License
* 文件描述：一切从简，只为了更懒！
*/
namespace App.Entity
{
	[DataContract]
	public partial class UserEntity
	{
		/// <summary>
		/// 描述：用户ID
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public int UserID { get; set; }

		/// <summary>
		/// 描述：用户昵称
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string UserName { get; set; }

		/// <summary>
		/// 描述：登录密码
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string UserPassword { get; set; }

		/// <summary>
		/// 描述：移动手机
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string UserPhone { get; set; }

		/// <summary>
		/// 描述：电子邮箱
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string UserEmail { get; set; }

		/// <summary>
		/// 描述：用户头像
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string UserPicture { get; set; }

		/// <summary>
		/// 描述：出生日期
		/// 可空：空
		/// </summary>
		[DataMember]
		public DateTime Birthday { get; set; }

		/// <summary>
		/// 描述：用户住址
		/// 可空：空
		/// </summary>
		[DataMember]
		public string Address { get; set; }

		/// <summary>
		/// 描述：用户性别，男/女
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string Gender { get; set; }

		/// <summary>
		/// 描述：身份职业，程序猿/设计师/攻城狮
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string Occupation { get; set; }

		/// <summary>
		/// 描述：个人描述
		/// 可空：空
		/// </summary>
		[DataMember]
		public string Describe { get; set; }

		/// <summary>
		/// 描述：QQ号码
		/// 可空：空
		/// </summary>
		[DataMember]
		public string QQ { get; set; }

		/// <summary>
		/// 描述：微信号码
		/// 可空：空
		/// </summary>
		[DataMember]
		public string WeiXin { get; set; }

		/// <summary>
		/// 描述：新浪微博号码
		/// 可空：空
		/// </summary>
		[DataMember]
		public string Sina { get; set; }

		/// <summary>
		/// 描述：注册时间
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public DateTime RegTime { get; set; }

		/// <summary>
		/// 描述：注册地址
		/// 可空：空
		/// </summary>
		[DataMember]
		public string RegAddress { get; set; }

		/// <summary>
		/// 描述：设备系统
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string DeviceOS { get; set; }

		/// <summary>
		/// 描述：设备系统版本号
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string DeviceOSVersion { get; set; }

		/// <summary>
		/// 描述：设备型号
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string DeviceModel { get; set; }

		/// <summary>
		/// 描述：设备名称
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string DeviceName { get; set; }

		/// <summary>
		/// 描述：设备唯一ID
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string DeviceId { get; set; }

		/// <summary>
		/// 描述：IOS设备推送Token
		/// 可空：空
		/// </summary>
		[DataMember]
		public string DeviceToken { get; set; }

		/// <summary>
		/// 描述：登录次数
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public int LoginCount { get; set; }

		/// <summary>
		/// 描述：即时通讯融云Token
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string RongCloudToken { get; set; }

		/// <summary>
		/// 描述：用户唯一标识
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public string UserGUID { get; set; }

		/// <summary>
		/// 描述：用户状态，10000（正常）/10001（QQ未绑定）/10002（微博未绑定）/10003（微信未绑定）/10004（用户已禁用）/10005（用户已被软删除）
		/// 可空：不为空
		/// </summary>
		[DataMember]
		public int Status { get; set; }

		/// <summary>
		/// 描述：用户状态改变原因
		/// 可空：空
		/// </summary>
		[DataMember]
		public string StatusChangeReason { get; set; }

	}
}