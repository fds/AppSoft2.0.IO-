* 文件名称：点点例数据库设计
* 文件作者：新生帝
* 编写日期：2016年02月10日
* 版权所有：中山赢友网络科技有限公司
* 企业官网：http://www.winu.net
* 开源协议：GPL v2 License
* 文件描述：一切从简，只为了更懒！

 *****

 > ### UserModel 用户表

 * `UserID`：用户ID，Int，主键，自增，NOT NULL
 * `UserName`：用户昵称，NVarchar(64)，NOT NULL
 * `UserPassword`：登录密码，Char(32)，NOT NULL
 * `UserPhone`：移动手机，Varchar(16)，NOT NULL
 * `UserEmail`：电子邮箱，Varchar(255)，NOT NULL
 * `UserPicture`：用户头像，Varchar(50)，NOT NULL
 * `Birthday`：出生日期，SmallDateTime，NULL
 * `Address`：用户地址，NVarchar(512)，NULL，
 * `Gender`：用户性别，Varchar(4)，NOT NULL，男/女
 * `Occupation`：身份职业，Varchar(16)，NOT NULL，程序猿/设计师/攻城狮
 * `Describe`：个人描述，NVarchar(255)，NULL，这家伙很懒，什么都没留下...
 * `QQ`：QQ号码，Varchar(16)，NULL
 * `WeiXin`：微信号码，Varchar(128)，NULL
 * `Sina`：新浪微博号码，Varchar(255)，NULL
 * `RegTime`：注册时间，Datetime，NOT NULL
 * `RegAddress`：注册地址，NVarchar(255)，NOT
 * `DeviceOS`：设备系统，Varchar(16)，NOT NULL，Android/IOS
 * `DeviceOSVersion`：设备系统版本，Varchar(16) NOT NULL
 * `DeviceModel`：设备型号，Varchar(32)，NOT NULL
 * `DeviceName`：设备名称，Varchar(32)，NOT NULL
 * `DeviceId`：设备唯一ID，Varchar(128)，NOT NULL
 * `DeviceToken`：IOS设备推送Token，Varchar(128)，NULL
 * `LoginCount`：登录次数，Int，NOT NULL，0
 * `RongCloudToken`：即时通讯融云Token，NVarchar(255)，NOT NULL
 * `UserGUID`：唯一标识，Varchar(50)，NOT NULL

