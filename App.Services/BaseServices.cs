using System;
using System.Collections.Generic;
using App.IServices;
using App.IRepository;
using System.Linq.Expressions;

/*!
 * 文件名称：服务基类
 * 文件作者：新生帝
 * 编写日期：2016年02月10日
 * 版权所有：中山赢友网络科技有限公司
 * 企业官网：http://www.winu.net
 * 开源协议：GPL v2 License
 * 文件描述：一切从简，只为了更懒！
 */

namespace App.Services
{
    public partial class BaseServices<T> : IBaseServices<T> where T : class, new()
    {
        protected IBaseRepository<T> _IBaseRepository;

        #region 方法：插入数据 + public object Insert(T entity, bool isIdentity = true)
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="isIdentity">是否包含主键</param>
        /// <returns></returns>
        public object Insert(T entity, bool isIdentity = true)
        {
            return _IBaseRepository.Insert(entity, isIdentity);
        }
        #endregion

        #region 方法：批量插入数据 + public List<object> InsertRange(List<T> entites, bool isIdentity = true)
        /// <summary>
        /// 批量插入数据
        /// </summary>
        /// <param name="entites">实体集合</param>
        /// <param name="isIdentity">是否包含主键</param>
        /// <returns></returns>
        public List<object> InsertRange(List<T> entites, bool isIdentity = true)
        {
            return _IBaseRepository.InsertRange(entites, isIdentity);
        }
        #endregion

        #region 方法：更新实体所有的列 + public bool Update(T model)
        /// <summary>
        /// 更新实体所有的列
        /// </summary>
        /// <param name="model">实体对象，主键必须是第一位</param>
        /// <returns></returns>
        public bool Update(T model)
        {
            return _IBaseRepository.Update(model);
        }
        #endregion

        #region 方法：更新数据 + public bool Update<FiledType>(object model, params FiledType[] whereIn)
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <typeparam name="FiledType"></typeparam>
        /// <param name="model">entity为T类型将更新该实体的非主键所有列，如果rowObj类型为匿名类将更新指定列</param>
        /// <param name="whereIn">条件数组</param>
        /// <returns></returns>
        public bool Update<FiledType>(object model, params FiledType[] whereIn)
        {
            return _IBaseRepository.Update<FiledType>(model, whereIn);
        }
        #endregion

        #region 方法：更新数据 + public bool Update(object model, Expression<Func<T, bool>> expression)
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="model">entity为T类型将更新该实体的非主键所有列，如果rowObj类型为匿名类将更新指定列</param>
        /// <param name="expression">Lambda表达式</param>
        /// <returns></returns>
        public bool Update(object model, Expression<Func<T, bool>> expression)
        {
            return _IBaseRepository.Update(model, expression);
        }
        #endregion

        #region 方法：删除数据 + public bool Delete<FiledType>(params FiledType[] whereIn)
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <typeparam name="FiledType"></typeparam>
        /// <param name="whereIn">条件数组</param>
        /// <returns></returns>
        public bool Delete<FiledType>(params FiledType[] whereIn)
        {
            return _IBaseRepository.Delete<FiledType>(whereIn);
        }
        #endregion

        #region 方法：删除数据 + public bool Delete(Expression<Func<T, bool>> expression)
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="expression">Lambda表达式</param>
        /// <returns></returns>
        public bool Delete(Expression<Func<T, bool>> expression)
        {
            return _IBaseRepository.Delete(expression);
        }
        #endregion

        #region 方法：假删除数据 + public bool FalseDelete<FiledType>(string filed, params FiledType[] whereIn)
        /// <summary>
        /// 假删除数据
        /// </summary>
        /// <typeparam name="FiledType"></typeparam>
        /// <param name="filed">更新删除状态字段</param>
        /// <param name="whereIn">过滤数组</param>
        /// <returns></returns>
        public bool FalseDelete<FiledType>(string filed, params FiledType[] whereIn)
        {
            return _IBaseRepository.FalseDelete<FiledType>(filed, whereIn);
        }
        #endregion

        #region 方法：假删除数据 + public bool FalseDelete(string filed, Expression<Func<T, bool>> expression)
        /// <summary>
        /// 假删除数据
        /// </summary>
        /// <param name="filed">更新删除状态字段</param>
        /// <param name="expression">Lambda表达式</param>
        /// <returns></returns>
        public bool FalseDelete(string filed, Expression<Func<T, bool>> expression)
        {
            return _IBaseRepository.FalseDelete(filed, expression);
        }
        #endregion

        #region 方法：查询一个 + public T QuerySingle()
        /// <summary>
        /// 查询一个
        /// </summary>
        /// <returns></returns>
        public T QuerySingle()
        {
            return _IBaseRepository.QuerySingle();
        }
        #endregion

        #region 方法：查询一个 + public T QuerySingle(Expression<Func<T, bool>> expression)
        /// <summary>
        /// 查询一个
        /// </summary>
        /// <param name="expression">Lambda表达式</param>
        /// <returns></returns>
        public T QuerySingle(Expression<Func<T, bool>> expression)
        {
            return _IBaseRepository.QuerySingle(expression);
        }
        #endregion

        #region 方法：查询所有 + public List<T> QueryAll()
        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public List<T> QueryAll()
        {
            return _IBaseRepository.QueryAll();
        }
        #endregion

        #region 方法：查询所有 + public List<T> QueryByWhere(Expression<Func<T, bool>> whereExpression, string orderbyStr)
        /// <summary>
        /// 查询所有
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="orderbyStr">排序字符串</param>
        /// <returns></returns>
        public List<T> QueryByWhere(Expression<Func<T, bool>> whereExpression, string orderbyStr)
        {
            return _IBaseRepository.QueryByWhere(whereExpression, orderbyStr);
        }
        #endregion

        #region 方法：查询所有 + public List<T> QueryByWhere(Expression<Func<T, bool>> whereExpression, string orderbyStr, string whereString = "1=1", object whereObj = null)
        /// <summary>
        /// 查询所有
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="orderbyStr">排序字段</param>
        /// <param name="whereString">where字符串</param>
        /// <param name="whereObj">命令参数对应匿名对象</param>
        /// <returns></returns>
        public List<T> QueryByWhere(Expression<Func<T, bool>> whereExpression, string orderbyStr, string whereString = "1=1", object whereObj = null)
        {
            return _IBaseRepository.QueryByWhere(whereExpression, orderbyStr, whereString, whereObj);
        }
        #endregion

        #region 方法：单表分页查询 + public List<T> QueryByWherePage(int pageIndex, int pageSize, Expression<Func<T, bool>> whereExpression, string orderbyStr)
        /// <summary>
        /// 单表分页查询
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页容量</param>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="orderbyStr">排序字段</param>
        /// <returns></returns>
        public List<T> QueryByWherePage(int pageIndex, int pageSize, Expression<Func<T, bool>> whereExpression, string orderbyStr)
        {
            return _IBaseRepository.QueryByWherePage(pageIndex, pageSize, whereExpression, orderbyStr);
        }
        #endregion

        #region 方法：单表分页查询 + public List<T> QueryByWherePage(int pageIndex, int pageSize, Expression<Func<T, bool>> whereExpression, string orderbyStr, string whereString = "1=1", object whereObj = null)
        /// <summary>
        /// 单表分页查询
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页容量</param>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="orderbyStr">排序字段</param>
        /// <param name="whereString">where字符串</param>
        /// <param name="whereObj">命令参数对应匿名对象</param>
        /// <returns></returns>
        public List<T> QueryByWherePage(int pageIndex, int pageSize, Expression<Func<T, bool>> whereExpression, string orderbyStr, string whereString = "1=1", object whereObj = null)
        {
            return _IBaseRepository.QueryByWherePage(pageIndex, pageSize, whereExpression, orderbyStr, whereString, whereObj);
        }
        #endregion

        #region 方法：查询索引多少到多少条 + public List<T> QueryByRange(int skipNum, int takeNum, Expression<Func<T, bool>> whereExpression, string orderbyStr)
        /// <summary>
        /// 查询索引多少到多少条
        /// </summary>
        /// <param name="skipNum">跳过的索引</param>
        /// <param name="takeNum">结束索引</param>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="orderbyStr">排序字段</param>
        /// <returns></returns>
        public List<T> QueryByRange(int skipNum, int takeNum, Expression<Func<T, bool>> whereExpression, string orderbyStr)
        {
            return _IBaseRepository.QueryByRange(skipNum, takeNum, whereExpression, orderbyStr);
        }
        #endregion

        #region 方法：查询索引后的所有数据 + public List<T> QuerySkipfterIndex(int skipNum, Expression<Func<T, bool>> whereExpression, string orderbyStr)
        /// <summary>
        /// 查询索引后的所有数据
        /// </summary>
        /// <param name="skipNum">跳过的索引</param>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="orderbyStr">排序字段</param>
        /// <returns></returns>
        public List<T> QuerySkipfterIndex(int skipNum, Expression<Func<T, bool>> whereExpression, string orderbyStr)
        {
            return _IBaseRepository.QuerySkipfterIndex(skipNum, whereExpression, orderbyStr);
        }
        #endregion

        #region 方法：查询指定个数的数据 + public List<T> QueryTakeIndex(int takeNum, Expression<Func<T, bool>> whereExpression, string orderbyStr)
        /// <summary>
        /// 查询指定个数的数据
        /// </summary>
        /// <param name="takeNum">指定个数</param>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="orderbyStr">排序字段</param>
        /// <returns></returns>
        public List<T> QueryTakeIndex(int takeNum, Expression<Func<T, bool>> whereExpression, string orderbyStr)
        {
            return _IBaseRepository.QueryTakeIndex(takeNum, whereExpression, orderbyStr);
        }
        #endregion

        #region 方法：查询条数 + public int QueryCount(Expression<Func<T, bool>> whereExpression)
        /// <summary>
        /// 查询条数
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <returns></returns>
        public int QueryCount(Expression<Func<T, bool>> whereExpression)
        {
            return _IBaseRepository.QueryCount(whereExpression);
        }
        #endregion

        #region 方法：查询是否存在记录 + public bool Any(Expression<Func<T, bool>> whereExpression)
        /// <summary>
        /// 查询是否存在记录
        /// </summary>
        /// <param name="whereExpression">条件表达式</param>
        /// <returns></returns>
        public bool Any(Expression<Func<T, bool>> whereExpression)
        {
            return _IBaseRepository.Any(whereExpression);
        }
        #endregion

        #region 方法：分组查询 + public List<TResult> QueryByGroup<TResult>(string groupbyFiles, string selectStr, Expression<Func<T, bool>> whereExpression, string orderbyStr)
        /// <summary>
        /// 分组查询
        /// </summary>
        /// <typeparam name="TResult">返回的新的实体数据</typeparam>
        /// <param name="groupbyFiles">分组字段</param>
        /// <param name="selectStr">筛选字段</param>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="orderbyStr">排序字段</param>
        /// <returns></returns>
        public List<TResult> QueryByGroup<TResult>(string groupbyFiles, string selectStr, Expression<Func<T, bool>> whereExpression, string orderbyStr)
        {
            return _IBaseRepository.QueryByGroup<TResult>(groupbyFiles, selectStr, whereExpression, orderbyStr);
        }
        #endregion

        #region 方法：分组查询 + public List<TResult> QueryByGroup<TResult>(string groupbyFiles, string selectStr, Expression<Func<T, bool>> whereExpression, string orderbyStr,string whereString = "1=1", object whereObj = null)
        /// <summary>
        /// 分组查询
        /// </summary>
        /// <typeparam name="TResult">返回的新的实体数据</typeparam>
        /// <param name="groupbyFiles">分组字段</param>
        /// <param name="selectStr">筛选字段</param>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="orderbyStr">排序字段</param>
        /// <param name="whereString">where字符串</param>
        /// <param name="whereObj">命令参数对应匿名对象</param>
        /// <returns></returns>
        public List<TResult> QueryByGroup<TResult>(string groupbyFiles, string selectStr, Expression<Func<T, bool>> whereExpression, string orderbyStr, string whereString = "1=1", object whereObj = null)
        {
            return _IBaseRepository.QueryByGroup<TResult>(groupbyFiles, selectStr, whereExpression, orderbyStr, whereString, whereObj);
        }
        #endregion

        #region 方法：分组查询 + public List<TResult> QueryByGroup<TResult>(string groupbyFiles, Expression<Func<T, TResult>> selectExpression, Expression<Func<T, bool>> whereExpression, string orderbyStr)
        /// <summary>
        /// 分组查询
        /// </summary>
        /// <typeparam name="TResult">返回的新的实体数据</typeparam>
        /// <param name="groupbyFiles">分组字段</param>
        /// <param name="selectExpression">筛选字段</param>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="orderbyStr">排序字段</param>
        /// <returns></returns>
        public List<TResult> QueryByGroup<TResult>(string groupbyFiles, Expression<Func<T, TResult>> selectExpression, Expression<Func<T, bool>> whereExpression, string orderbyStr)
        {
            return _IBaseRepository.QueryByGroup<TResult>(groupbyFiles, selectExpression, whereExpression, orderbyStr);
        }
        #endregion

        #region 方法：分组查询 + public List<TResult> QueryByGroup<TResult>(string groupbyFiles, Expression<Func<T, TResult>> selectExpression, Expression<Func<T, bool>> whereExpression, string orderbyStr, string whereString = "1=1", object whereObj = null)
        /// <summary>
        /// 分组查询
        /// </summary>
        /// <typeparam name="TResult">返回的新的实体数据</typeparam>
        /// <param name="groupbyFiles">分组字段</param>
        /// <param name="selectExpression">筛选字段</param>
        /// <param name="whereExpression">条件表达式</param>
        /// <param name="orderbyStr">排序字段</param>
        /// <param name="whereString">where字符串</param>
        /// <param name="whereObj">命令参数对应匿名对象</param>
        /// <returns></returns>
        public List<TResult> QueryByGroup<TResult>(string groupbyFiles, Expression<Func<T, TResult>> selectExpression, Expression<Func<T, bool>> whereExpression, string orderbyStr, string whereString = "1=1", object whereObj = null)
        {
            return _IBaseRepository.QueryByGroup<TResult>(groupbyFiles, selectExpression, whereExpression, orderbyStr, whereString, whereObj);
        }
        #endregion

        #region 方法：执行sql语句或存储过程 + public List<TResult> QueryBySql<TResult>(string sql, object whereObj = null)
        /// <summary>
        /// 执行sql语句或存储过程
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="whereObj">命令参数对应匿名对象</param>
        /// <returns></returns>
        public List<TResult> QueryBySql<TResult>(string sql, object whereObj = null)
        {
            return _IBaseRepository.QueryBySql<TResult>(sql, whereObj);
        }
        #endregion

        #region 方法：执行sql语句或存储过程 + public List<TResult> QueryBySqlTransactions<TResult>(string sql, object whereObj = null)
        /// <summary>
        /// 执行sql语句或存储过程
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="whereObj">命令参数对应匿名对象</param>
        /// <returns></returns>
        public List<TResult> QueryBySqlTransactions<TResult>(string sql, object whereObj = null)
        {
            return _IBaseRepository.QueryBySqlTransactions<TResult>(sql, whereObj);
        }
        #endregion

        /*
         * 多表查询建议用视图或者存储过程，就不再封装，有必要时添加拓展方法
         */
    }
}
