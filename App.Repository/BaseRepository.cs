using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
using System.Linq.Expressions;
using App.SqlSugarHelper;
using App.IRepository;

/*!
 * 文件名称：仓储基类
 * 文件作者：新生帝
 * 编写日期：2016年02月10日
 * 版权所有：中山赢友网络科技有限公司
 * 企业官网：http://www.winu.net
 * 开源协议：GPL v2 License
 * 文件描述：一切从简，只为了更懒！
 */

namespace App.Repository
{
    public partial class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        #region 方法：插入数据 + public object Insert(T entity, bool isIdentity = true)
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="isIdentity">是否包含主键</param>
        /// <returns></returns>
        public object Insert(T entity, bool isIdentity = true)
        {
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Insert<T>(entity, isIdentity);
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                try
                {
                    dbClient.BeginTran();
                    return dbClient.InsertRange<T>(entites, isIdentity);
                }
                catch (Exception ex)
                {
                    dbClient.RollbackTran();
                    throw ex;
                }
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                try
                {
                    dbClient.BeginTran();
                    return dbClient.Update<T, FiledType>(model, whereIn);
                }
                catch (Exception ex)
                {
                    dbClient.RollbackTran();
                    throw ex;
                }
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                try
                {
                    dbClient.BeginTran();
                    return dbClient.Update<T>(model, expression);
                }
                catch (Exception ex)
                {
                    dbClient.RollbackTran();
                    throw ex;
                }
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                try
                {
                    dbClient.BeginTran();
                    return dbClient.Delete<T, FiledType>(whereIn);
                }
                catch (Exception ex)
                {
                    dbClient.RollbackTran();
                    throw ex;
                }
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                try
                {
                    dbClient.BeginTran();
                    return dbClient.Delete<T>(expression);
                }
                catch (Exception ex)
                {
                    dbClient.RollbackTran();
                    throw ex;
                }
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                try
                {
                    dbClient.BeginTran();
                    return dbClient.FalseDelete<T, FiledType>(filed, whereIn);
                }
                catch (Exception ex)
                {
                    dbClient.RollbackTran();
                    throw ex;
                }
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                try
                {
                    dbClient.BeginTran();
                    return dbClient.FalseDelete<T>(filed, expression);
                }
                catch (Exception ex)
                {
                    dbClient.RollbackTran();
                    throw ex;
                }
            }
        }
        #endregion

        #region 方法：查询一个 + public T QuerySingle()
        /// <summary>
        /// 查询一个
        /// </summary>
        /// <returns></returns>
        public T QuerySingle()
        {
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Single();
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Single(expression);
            }
        }
        #endregion

        #region 方法：查询所有 + public List<T> QueryAll()
        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public List<T> QueryAll()
        {
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().ToList();
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Where(whereExpression).OrderBy(orderbyStr).ToList();
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Where(whereExpression).Where(whereString, whereObj).OrderBy(orderbyStr).ToList();
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Where(whereExpression).OrderBy(orderbyStr).ToPageList(pageIndex, pageSize);
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Where(whereExpression).Where(whereString, whereObj).OrderBy(orderbyStr).ToPageList(pageIndex, pageSize);
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Where(whereExpression).OrderBy(orderbyStr).Skip(skipNum).Take(takeNum).ToList();
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Where(whereExpression).OrderBy(orderbyStr).Skip(skipNum).ToList();
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Where(whereExpression).OrderBy(orderbyStr).Take(takeNum).ToList();
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Where(whereExpression).Count();
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Any(whereExpression);
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Where(whereExpression).GroupBy(groupbyFiles).Select<T, TResult>(selectStr).OrderBy(orderbyStr).ToList();
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Where(whereExpression).Where(whereString, whereObj).GroupBy(groupbyFiles).Select<T, TResult>(selectStr).OrderBy(orderbyStr).ToList();
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Where(whereExpression).GroupBy(groupbyFiles).Select<T, TResult>(selectExpression).OrderBy(orderbyStr).ToList();
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.Queryable<T>().Where(whereExpression).Where(whereString, whereObj).GroupBy(groupbyFiles).Select<T, TResult>(selectExpression).OrderBy(orderbyStr).ToList();
            }
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
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                return dbClient.SqlQuery<TResult>(sql, whereObj);
            }
        }
        #endregion

        #region 方法：事务执行sql语句或存储过程 + public List<TResult> QueryBySqlTransactions<TResult>(string sql, object whereObj = null)
        /// <summary>
        /// 事务执行sql语句或存储过程
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sql">sql语句</param>
        /// <param name="whereObj">命令参数对应匿名对象</param>
        /// <returns></returns>
        public List<TResult> QueryBySqlTransactions<TResult>(string sql, object whereObj = null)
        {
            using (SqlSugarClient dbClient = SqlSugarInstance.GetInstance())
            {
                try
                {
                    dbClient.BeginTran();
                    return dbClient.SqlQuery<TResult>(sql, whereObj);
                }
                catch (Exception ex)
                {
                    dbClient.RollbackTran();
                    throw ex;
                }
            }
        }
        #endregion

        /*
         * 多表查询建议用视图或者存储过程，就不再封装，有必要时添加拓展方法
         */
    }
}
