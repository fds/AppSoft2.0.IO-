using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

/*!
 * 文件名称：Json序列化
 * 文件作者：新生帝
 * 编写日期：2016年02月13日
 * 版权所有：中山赢友网络科技有限公司
 * 企业官网：http://www.winu.net
 * 开源协议：GPL v2 License
 * 文件描述：一切从简，只为了更懒！
 */

namespace App.Library
{
    public class JsonHelper
    {
        #region 静态：对象转换成json + public static string DataContractJsonSerialize<T>(T jsonObject)
        /// <summary>
        /// 对象转换成json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonObject">需要格式化的对象</param>
        /// <returns>Json字符串</returns>
        public static string DataContractJsonSerialize<T>(T jsonObject)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            string json = null;
            using (var ms = new MemoryStream()) //定义一个stream用来存发序列化之后的内容
            {
                serializer.WriteObject(ms, jsonObject);
                var dataBytes = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(dataBytes, 0, (int)ms.Length);
                json = Encoding.UTF8.GetString(dataBytes);
                ms.Close();
            }
            return json;
        }
        #endregion

        #region 方法：json字符串转换成对象 + public static T DataContractJsonDeserialize<T>(string json)
        /// <summary>
        /// json字符串转换成对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json">要转换成对象的json字符串</param>
        /// <returns></returns>
        public static T DataContractJsonDeserialize<T>(string json)
        {
            var serializer = new DataContractJsonSerializer(typeof(T));
            var obj = default(T);
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                obj = (T)serializer.ReadObject(ms);
                ms.Close();
            }
            return obj;
        }
        #endregion
    }
}
