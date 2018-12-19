using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using System.Reflection;

namespace FS.Crawler.Common
{
    public class DapperHelper
    {
        private readonly static string connString = ConfigurationSettings.AppSettings["ConnString"].ToString();

        private DapperHelper()
        {
            
        }
        /// <summary>
        /// 执行
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        private static int Execute<T>(string sql,T entity)
        {
            using (IDbConnection connection = new SqlConnection(connString))
            {
                return connection.Execute(sql, entity);
            }
        }
        private static int Execute<T>(string sql, List<T> list)
        {
            using (IDbConnection connection = new SqlConnection(connString))
            {
                return connection.Execute(sql, list);
            }
        }
        /// <summary>
        /// 生成insert sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        private static string GetInsertSql<T>(T entity)
        {
            var tableName = entity.GetType().Name;
            StringBuilder sql = new StringBuilder(string.Format("Insert into {0} values(", tableName));
            PropertyInfo[] properties = entity.GetType().GetProperties();
            int i = 0;
            foreach (var item in properties)
            {
                if (i > 0) sql.Append(",");
                sql.Append("@" + item.Name);
                i++;
            }
            sql.Append(")");
            return sql.ToString();
        }

        private static string GetCreatTableSql<T>(T entity)
        {
            var tableName = entity.GetType().Name;
            StringBuilder sql = new StringBuilder(string.Format("if not exists(select * from sys.Tables where name='{0}')", tableName));
            sql.AppendLine(string.Format("create table {0}", tableName));
            sql.AppendLine(string.Format("("));
            PropertyInfo[] properties = entity.GetType().GetProperties();
            int i = 0;
            foreach (PropertyInfo item in properties)
            {
                var columnType = item.PropertyType.ToString();
                switch (columnType)
                {
                    case "System.String":
                        columnType = "nvarchar(500)";
                        break;
                    case "System.Int32":
                        columnType = "int";
                        break;
                    case "System.Decimal":
                        columnType = "decimal(18,2)";
                        break;
                    default:
                        columnType = "nvarchar(500)";
                        break;
                }
                if (i > 0) sql.Append(",");
                sql.AppendLine(item.Name + "  " + columnType);
                i++;
            }
            sql.AppendLine(")");
            return sql.ToString();
        }
        /// <summary>
        /// 根据实体创建表
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static int CreateTable<T>(T entity)
        {
            var sql = GetCreatTableSql<T>(entity);
            return  Execute<T>(sql.ToString(),entity);
        }
        public static int InsertEntity<T>(T entity)
        {
            var sql = GetInsertSql<T>(entity);
            return Execute<T>(sql, entity);
        }
        public static int InsertEntity<T>(List<T> list)
        {
            var sql = GetInsertSql<T>(list[0]);
            return Execute<T>(sql, list);
        }
    }
}
