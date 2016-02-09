using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

/*!
 * 插件名称：返回SqlSugarClient实体类
 * 插件作者：新生帝
 * 编写日期：2016年02月09日
 * 版权所有：中山赢友网络科技有限公司
 * 企业官网：http://www.winu.net
 * 开源协议：GPL v2 License
 * 插件描述：一切从简，只为了更懒！
 */

namespace App.SqlSugarHelper
{
    public class SqlSugarInstance
    {
        #region 构造：无参构造函数，禁止实例化 + public SqlSugarInstance()
        /// <summary>
        /// 禁止实例化
        /// </summary>
        public SqlSugarInstance()
        {
        }
        #endregion

        #region 静态：获取Sugar客户端实例对象 + public static SqlSugarClient GetInstance()
        /// <summary>
        /// 获取Sugar客户端实例对象
        /// </summary>
        /// <returns>SqlSugarClient</returns>
        public static SqlSugarClient GetInstance()
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings[@"AppSoft.IO_ConnStr"].ToString();
            return new SqlSugarClient(connection);
        }
        #endregion
    }
}
