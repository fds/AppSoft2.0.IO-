* 文件名称：点点例数据库设计
* 文件作者：新生帝
* 编写日期：2016年02月10日
* 版权所有：中山赢友网络科技有限公司
* 企业官网：http://www.winu.net
* 开源协议：GPL v2 License
* 文件描述：一切从简，只为了更懒！

 *****

 > ### Dot_UserEntity 用户表

 * `UserID`：用户ID，INT，主键，自增，NOT NULL
 * `UserName`：用户昵称，NVARCHAR(64)，NOT NULL
 * `UserPassword`：登录密码，CHAR(32)，NOT NULL
 * `UserPhone`：移动手机，VARCHAR(16)，NOT NULL
 * `UserEmail`：电子邮箱，VARCHAR(255)，NOT NULL
 * `UserPicture`：用户头像，VARCHAR(50)，NOT NULL
 * `Birthday`：出生日期，SMALLDATETIME，NULL，1990-01-01
 * `Address`：用户住址，NVARCHAR(512)，NULL，
 * `Gender`：用户性别，VARCHAR(8)，NOT NULL，男/女
 * `Occupation`：身份职业，VARCHAR(16)，NOT NULL，程序猿/设计师/攻城狮
 * `Describe`：个人描述，NVARCHAR(255)，NULL，这家伙很懒，什么都没留下...
 * `QQ`：QQ号码，VARCHAR(16)，NULL
 * `WeiXin`：微信号码，VARCHAR(128)，NULL
 * `Sina`：新浪微博号码，VARCHAR(255)，NULL
 * `RegTime`：注册时间，DATETIME，NOT NULL
 * `RegAddress`：注册地址，NVARCHAR(255)，NOT
 * `DeviceOS`：设备系统，VARCHAR(16)，NOT NULL，Android/IOS
 * `DeviceOSVersion`：设备系统版本，VARCHAR(16) NOT NULL
 * `DeviceModel`：设备型号，VARCHAR(32)，NOT NULL
 * `DeviceName`：设备名称，VARCHAR(32)，NOT NULL
 * `DeviceId`：设备唯一ID，VARCHAR(128)，NOT NULL
 * `DeviceToken`：IOS设备推送Token，VARCHAR(128)，NULL
 * `LoginCount`：登录次数，INT，NOT NULL，0
 * `RongCloudToken`：即时通讯融云Token，VARCHAR(255)，NOT NULL
 * `UserGUID`：用户唯一标识，VARCHAR(50)，NOT NULL
 * `Status`：用户状态，INT，NOT NULL，10000（正常）/10001（QQ未绑定）/10002（微博未绑定）/10003（微信未绑定）/10004（用户已禁用）/10005（用户已被软删除）
 * `StatusChangeReason`：用户状态改变原因，NVARCHAR(255)，NULL，无

