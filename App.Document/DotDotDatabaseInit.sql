/*!
* 文件名称：点点例数据库初始化脚本
* 文件作者：新生帝
* 编写日期：2016年02月11日
* 版权所有：中山赢友网络科技有限公司
* 企业官网：http://www.winu.net
* 开源协议：GPL v2 License
* 文件描述：一切从简，只为了更懒！
*/
USE DotDot
GO

-- #### UserEntity 用户表

IF(OBJECT_ID('UserEntity','U') IS NOT NULL)
	DROP TABLE [UserEntity]
GO
CREATE TABLE [UserEntity]
(
	UserID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,	-- 用户ID
	UserName NVARCHAR(64) NOT NULL,	-- 用户昵称
	UserPassword CHAR(32) NOT NULL,	-- 登录密码
	UserPhone VARCHAR(16) NOT NULL,	-- 移动手机
	UserEmail VARCHAR(255) NOT NULL,	-- 电子邮箱
	UserPicture VARCHAR(50) NOT NULL,	-- 用户头像
	Birthday SMALLDATETIME NULL DEFAULT('1990-01-01'),	-- 出生日期
	Address NVARCHAR(512) NULL,	-- 用户住址
	Gender VARCHAR(8) NOT NULL,	-- 用户性别，男/女
	Occupation VARCHAR(16) NOT NULL,	-- 身份职业，程序猿/设计师/攻城狮
	Describe NVARCHAR(255) NULL DEFAULT('这家伙很懒，什么都没留下...'),	-- 个人描述
	QQ VARCHAR(16) NULL,	-- QQ号码
	WeiXin VARCHAR(128) NULL,	-- 微信号码
	Sina VARCHAR(255) NULL,	-- 新浪微博号码
	RegTime DATETIME NOT NULL DEFAULT(GETDATE()),	-- 注册时间
	RegAddress NVARCHAR(255) NULL,	-- 注册地址
	DeviceOS VARCHAR(16) NOT NULL,	-- 设备系统
	DeviceOSVersion VARCHAR(16) NOT NULL,	-- 设备系统版本号
	DeviceModel VARCHAR(32) NOT NULL,	-- 设备型号
	DeviceName VARCHAR(32) NOT NULL,	-- 设备名称
	DeviceId VARCHAR(128) NOT NULL,	-- 设备唯一ID
	DeviceToken VARCHAR(128) NULL,	-- IOS设备推送Token
	LoginCount INT NOT NULL DEFAULT(0),	-- 登录次数
	RongCloudToken VARCHAR(255) NOT NULL,	-- 即时通讯融云Token
	UserGUID VARCHAR(50) NOT NULL DEFAULT(NEWID()),	-- 用户唯一标识
	Status INT NOT NULL,	-- 用户状态，10000（正常）/10001（QQ未绑定）/10002（微博未绑定）/10003（微信未绑定）/10004（用户已禁用）/10005（用户已被软删除）
	StatusChangeReason NVARCHAR(255) NULL DEFAULT('无')	-- 用户状态改变原因
)
GO
EXEC sp_addextendedproperty N'MS_Description', N'用户ID', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserID';
EXEC sp_addextendedproperty N'MS_Description', N'用户昵称', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserName';
EXEC sp_addextendedproperty N'MS_Description', N'登录密码', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserPassword';
EXEC sp_addextendedproperty N'MS_Description', N'移动手机', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserPhone';
EXEC sp_addextendedproperty N'MS_Description', N'电子邮箱', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserEmail';
EXEC sp_addextendedproperty N'MS_Description', N'用户头像', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserPicture';
EXEC sp_addextendedproperty N'MS_Description', N'出生日期', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Birthday';
EXEC sp_addextendedproperty N'MS_Description', N'用户住址', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Address';
EXEC sp_addextendedproperty N'MS_Description', N'用户性别，男/女', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Gender';
EXEC sp_addextendedproperty N'MS_Description', N'身份职业，程序猿/设计师/攻城狮', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Occupation';
EXEC sp_addextendedproperty N'MS_Description', N'个人描述', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Describe';
EXEC sp_addextendedproperty N'MS_Description', N'QQ号码', N'user', N'dbo', N'table', N'UserEntity', N'column', N'QQ';
EXEC sp_addextendedproperty N'MS_Description', N'微信号码', N'user', N'dbo', N'table', N'UserEntity', N'column', N'WeiXin';
EXEC sp_addextendedproperty N'MS_Description', N'新浪微博号码', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Sina';
EXEC sp_addextendedproperty N'MS_Description', N'注册时间', N'user', N'dbo', N'table', N'UserEntity', N'column', N'RegTime';
EXEC sp_addextendedproperty N'MS_Description', N'注册地址', N'user', N'dbo', N'table', N'UserEntity', N'column', N'RegAddress';
EXEC sp_addextendedproperty N'MS_Description', N'设备系统', N'user', N'dbo', N'table', N'UserEntity', N'column', N'DeviceOS';
EXEC sp_addextendedproperty N'MS_Description', N'设备系统版本号', N'user', N'dbo', N'table', N'UserEntity', N'column', N'DeviceOSVersion';
EXEC sp_addextendedproperty N'MS_Description', N'设备型号', N'user', N'dbo', N'table', N'UserEntity', N'column', N'DeviceModel';
EXEC sp_addextendedproperty N'MS_Description', N'设备名称', N'user', N'dbo', N'table', N'UserEntity', N'column', N'DeviceName';
EXEC sp_addextendedproperty N'MS_Description', N'设备唯一ID', N'user', N'dbo', N'table', N'UserEntity', N'column', N'DeviceId';
EXEC sp_addextendedproperty N'MS_Description', N'IOS设备推送Token', N'user', N'dbo', N'table', N'UserEntity', N'column', N'DeviceToken';
EXEC sp_addextendedproperty N'MS_Description', N'登录次数', N'user', N'dbo', N'table', N'UserEntity', N'column', N'LoginCount';
EXEC sp_addextendedproperty N'MS_Description', N'即时通讯融云Token', N'user', N'dbo', N'table', N'UserEntity', N'column', N'RongCloudToken';
EXEC sp_addextendedproperty N'MS_Description', N'用户唯一标识', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserGUID';
EXEC sp_addextendedproperty N'MS_Description', N'用户状态，10000（正常）/10001（QQ未绑定）/10002（微博未绑定）/10003（微信未绑定）/10004（用户已禁用）/10005（用户已被软删除）', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Status';
EXEC sp_addextendedproperty N'MS_Description', N'用户状态改变原因', N'user', N'dbo', N'table', N'UserEntity', N'column', N'StatusChangeReason';
