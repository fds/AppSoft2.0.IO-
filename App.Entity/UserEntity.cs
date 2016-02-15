using System;
using System.Runtime.Serialization;

/*!
* 文件名称：UserEntity实体类
* 文件作者：新生帝
* 编写日期：2016-02-16 02:17:26
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
		/// 用户ID
		/// </summary>
		[DataMember]
		public int UserID { get; set; }

		/// <summary>
		/// 用户昵称
		/// </summary>
		[DataMember]
		public string UserName { get; set; }

		/// <summary>
		/// 登录密码
		/// </summary>
		[DataMember]
		public string UserPassword { get; set; }

		/// <summary>
		/// 移动手机
		/// </summary>
		[DataMember]
		public string UserPhone { get; set; }

		/// <summary>
		/// 电子邮箱
		/// </summary>
		[DataMember]
		public string UserEmail { get; set; }

		/// <summary>
		/// 用户头像
		/// </summary>
		[DataMember]
		public string UserPicture { get; set; }

		/// <summary>
		/// 出生日期
		/// </summary>
		[DataMember]
		public DateTime Birthday { get; set; }

		/// <summary>
		/// 用户住址
		/// </summary>
		[DataMember]
		public string Address { get; set; }

		/// <summary>
		/// 用户性别，男/女
		/// </summary>
		[DataMember]
		public string Gender { get; set; }

		/// <summary>
		/// 身份职业，程序猿/设计师/攻城狮
		/// </summary>
		[DataMember]
		public string Occupation { get; set; }

		/// <summary>
		/// 个人描述
		/// </summary>
		[DataMember]
		public string Describe { get; set; }

		/// <summary>
		/// QQ号码
		/// </summary>
		[DataMember]
		public string QQ { get; set; }

		/// <summary>
		/// 微信号码
		/// </summary>
		[DataMember]
		public string WeiXin { get; set; }

		/// <summary>
		/// 新浪微博号码
		/// </summary>
		[DataMember]
		public string Sina { get; set; }

		/// <summary>
		/// 注册时间
		/// </summary>
		[DataMember]
		public DateTime RegTime { get; set; }

		/// <summary>
		/// 注册地址
		/// </summary>
		[DataMember]
		public string RegAddress { get; set; }

		/// <summary>
		/// 设备系统
		/// </summary>
		[DataMember]
		public string DeviceOS { get; set; }

		/// <summary>
		/// 设备系统版本号
		/// </summary>
		[DataMember]
		public string DeviceOSVersion { get; set; }

		/// <summary>
		/// 设备型号
		/// </summary>
		[DataMember]
		public string DeviceModel { get; set; }

		/// <summary>
		/// 设备名称
		/// </summary>
		[DataMember]
		public string DeviceName { get; set; }

		/// <summary>
		/// 设备唯一ID
		/// </summary>
		[DataMember]
		public string DeviceId { get; set; }

		/// <summary>
		/// IOS设备推送Token
		/// </summary>
		[DataMember]
		public string DeviceToken { get; set; }

		/// <summary>
		/// 登录次数
		/// </summary>
		[DataMember]
		public int LoginCount { get; set; }

		/// <summary>
		/// 即时通讯融云Token
		/// </summary>
		[DataMember]
		public string RongCloudToken { get; set; }

		/// <summary>
		/// 用户唯一标识
		/// </summary>
		[DataMember]
		public string UserGUID { get; set; }

		/// <summary>
		/// 用户状态，10000（正常）/10001（QQ未绑定）/10002（微博未绑定）/10003（微信未绑定）/10004（用户已禁用）/10005（用户已被软删除）
		/// </summary>
		[DataMember]
		public int Status { get; set; }

		/// <summary>
		/// 用户状态改变原因
		/// </summary>
		[DataMember]
		public string StatusChangeReason { get; set; }

	}
}