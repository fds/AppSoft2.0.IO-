/*!
* �ļ����ƣ���������ݿ��ʼ���ű�
* �ļ����ߣ�������
* ��д���ڣ�2016��02��11��
* ��Ȩ���У���ɽӮ������Ƽ����޹�˾
* ��ҵ������http://www.winu.net
* ��ԴЭ�飺GPL v2 License
* �ļ�������һ�дӼ�ֻΪ�˸�����
*/
USE DotDot
GO

-- #### UserEntity �û���

IF(OBJECT_ID('UserEntity','U') IS NOT NULL)
	DROP TABLE [UserEntity]
GO
CREATE TABLE [UserEntity]
(
	UserID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,	-- �û�ID
	UserName NVARCHAR(64) NOT NULL,	-- �û��ǳ�
	UserPassword CHAR(32) NOT NULL,	-- ��¼����
	UserPhone VARCHAR(16) NOT NULL,	-- �ƶ��ֻ�
	UserEmail VARCHAR(255) NOT NULL,	-- ��������
	UserPicture VARCHAR(50) NOT NULL,	-- �û�ͷ��
	Birthday SMALLDATETIME NULL DEFAULT('1990-01-01'),	-- ��������
	Address NVARCHAR(512) NULL,	-- �û�סַ
	Gender VARCHAR(8) NOT NULL,	-- �û��Ա���/Ů
	Occupation VARCHAR(16) NOT NULL,	-- ���ְҵ������Գ/���ʦ/����ʨ
	Describe NVARCHAR(255) NULL DEFAULT('��һ������ʲô��û����...'),	-- ��������
	QQ VARCHAR(16) NULL,	-- QQ����
	WeiXin VARCHAR(128) NULL,	-- ΢�ź���
	Sina VARCHAR(255) NULL,	-- ����΢������
	RegTime DATETIME NOT NULL DEFAULT(GETDATE()),	-- ע��ʱ��
	RegAddress NVARCHAR(255) NULL,	-- ע���ַ
	DeviceOS VARCHAR(16) NOT NULL,	-- �豸ϵͳ
	DeviceOSVersion VARCHAR(16) NOT NULL,	-- �豸ϵͳ�汾��
	DeviceModel VARCHAR(32) NOT NULL,	-- �豸�ͺ�
	DeviceName VARCHAR(32) NOT NULL,	-- �豸����
	DeviceId VARCHAR(128) NOT NULL,	-- �豸ΨһID
	DeviceToken VARCHAR(128) NULL,	-- IOS�豸����Token
	LoginCount INT NOT NULL DEFAULT(0),	-- ��¼����
	RongCloudToken VARCHAR(255) NOT NULL,	-- ��ʱͨѶ����Token
	UserGUID VARCHAR(50) NOT NULL DEFAULT(NEWID()),	-- �û�Ψһ��ʶ
	Status INT NOT NULL,	-- �û�״̬��10000��������/10001��QQδ�󶨣�/10002��΢��δ�󶨣�/10003��΢��δ�󶨣�/10004���û��ѽ��ã�/10005���û��ѱ���ɾ����
	StatusChangeReason NVARCHAR(255) NULL DEFAULT('��')	-- �û�״̬�ı�ԭ��
)
GO
EXEC sp_addextendedproperty N'MS_Description', N'�û�ID', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserID';
EXEC sp_addextendedproperty N'MS_Description', N'�û��ǳ�', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserName';
EXEC sp_addextendedproperty N'MS_Description', N'��¼����', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserPassword';
EXEC sp_addextendedproperty N'MS_Description', N'�ƶ��ֻ�', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserPhone';
EXEC sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserEmail';
EXEC sp_addextendedproperty N'MS_Description', N'�û�ͷ��', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserPicture';
EXEC sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Birthday';
EXEC sp_addextendedproperty N'MS_Description', N'�û�סַ', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Address';
EXEC sp_addextendedproperty N'MS_Description', N'�û��Ա���/Ů', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Gender';
EXEC sp_addextendedproperty N'MS_Description', N'���ְҵ������Գ/���ʦ/����ʨ', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Occupation';
EXEC sp_addextendedproperty N'MS_Description', N'��������', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Describe';
EXEC sp_addextendedproperty N'MS_Description', N'QQ����', N'user', N'dbo', N'table', N'UserEntity', N'column', N'QQ';
EXEC sp_addextendedproperty N'MS_Description', N'΢�ź���', N'user', N'dbo', N'table', N'UserEntity', N'column', N'WeiXin';
EXEC sp_addextendedproperty N'MS_Description', N'����΢������', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Sina';
EXEC sp_addextendedproperty N'MS_Description', N'ע��ʱ��', N'user', N'dbo', N'table', N'UserEntity', N'column', N'RegTime';
EXEC sp_addextendedproperty N'MS_Description', N'ע���ַ', N'user', N'dbo', N'table', N'UserEntity', N'column', N'RegAddress';
EXEC sp_addextendedproperty N'MS_Description', N'�豸ϵͳ', N'user', N'dbo', N'table', N'UserEntity', N'column', N'DeviceOS';
EXEC sp_addextendedproperty N'MS_Description', N'�豸ϵͳ�汾��', N'user', N'dbo', N'table', N'UserEntity', N'column', N'DeviceOSVersion';
EXEC sp_addextendedproperty N'MS_Description', N'�豸�ͺ�', N'user', N'dbo', N'table', N'UserEntity', N'column', N'DeviceModel';
EXEC sp_addextendedproperty N'MS_Description', N'�豸����', N'user', N'dbo', N'table', N'UserEntity', N'column', N'DeviceName';
EXEC sp_addextendedproperty N'MS_Description', N'�豸ΨһID', N'user', N'dbo', N'table', N'UserEntity', N'column', N'DeviceId';
EXEC sp_addextendedproperty N'MS_Description', N'IOS�豸����Token', N'user', N'dbo', N'table', N'UserEntity', N'column', N'DeviceToken';
EXEC sp_addextendedproperty N'MS_Description', N'��¼����', N'user', N'dbo', N'table', N'UserEntity', N'column', N'LoginCount';
EXEC sp_addextendedproperty N'MS_Description', N'��ʱͨѶ����Token', N'user', N'dbo', N'table', N'UserEntity', N'column', N'RongCloudToken';
EXEC sp_addextendedproperty N'MS_Description', N'�û�Ψһ��ʶ', N'user', N'dbo', N'table', N'UserEntity', N'column', N'UserGUID';
EXEC sp_addextendedproperty N'MS_Description', N'�û�״̬��10000��������/10001��QQδ�󶨣�/10002��΢��δ�󶨣�/10003��΢��δ�󶨣�/10004���û��ѽ��ã�/10005���û��ѱ���ɾ����', N'user', N'dbo', N'table', N'UserEntity', N'column', N'Status';
EXEC sp_addextendedproperty N'MS_Description', N'�û�״̬�ı�ԭ��', N'user', N'dbo', N'table', N'UserEntity', N'column', N'StatusChangeReason';
