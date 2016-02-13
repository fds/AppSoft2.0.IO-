using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*!
 * 文件名称：Redis帮助库
 * 文件作者：新生帝
 * 编写日期：2016年02月13日
 * 版权所有：中山赢友网络科技有限公司
 * 企业官网：http://www.winu.net
 * 开源协议：GPL v2 License
 * 文件描述：一切从简，只为了更懒！
 */

namespace App.Vector
{
    public class RedisHelper
    {
        static RedisClient redisClient = new RedisClient("127.0.0.1", 6379);

        #region 静态：获取数据 + public static T GetData<T>(string key)
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <typeparam name="T">返回数据类型</typeparam>
        /// <param name="key">Key</param>
        /// <returns></returns>
        public static T GetData<T>(string key)
        {
            return redisClient.Get<T>(key);
        }
        #endregion

        #region 静态：设置数据 + public static bool SetData<T>(string key, T value)
        /// <summary>
        /// 设置数据
        /// </summary>
        /// <typeparam name="T">设置的类型</typeparam>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        public static bool SetData<T>(string key, T value)
        {
            return redisClient.Set<T>(key, value);
        }
        #endregion

        #region 静态：移除数据 + public static bool RemoveData(string key)
        /// <summary>
        /// 移除数据
        /// </summary>
        /// <param name="key">键</param>
        /// <returns></returns>
        public static bool RemoveData(string key)
        {
            return redisClient.Remove(key);
        }
        #endregion
    }
}
