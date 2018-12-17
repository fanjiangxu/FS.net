using FS.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.CodeBuilder
{
    class Program
    {
        public static string connStr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString.ToString();
        public static string modelPath = ConfigurationManager.AppSettings["ModelPath"].ToString();
        public static string IServicePath = ConfigurationManager.AppSettings["IServicePath"].ToString();
        public static string ServicePath = ConfigurationManager.AppSettings["ServicePath"].ToString();
        public static string ControllerPath = ConfigurationManager.AppSettings["ControllerPath"].ToString();
        public static DataTable tableNameDT = GetTableName();
        public static DataTable allTableColumns= GetTableColumns();
        static void Main(string[] args)
        {
            //创建文件
            CreateFile();
            Console.Write("执行成功");
            Console.ReadLine();
        }
        public static void CreateFile()
        {
            for (var i = 0; i < tableNameDT.Rows.Count; i++)
            {
                string tablename = tableNameDT.Rows[i]["name"].ToString();
                if (tablename.Contains("$")||tablename.Contains("Models") || tablename.Contains("SheetSZ1") || tablename.Contains("spuid无库存") || tablename.Contains("Sheet1$"))
                {
                    continue;
                }
                ControllerFile(tablename);
                ServiceFile(tablename);
                IServiceFile(tablename);
                ModelFile(tablename);
            }
        }
        #region 字符串拼接
        private static void ControllerFile(string tableName)
        {
            var entityName = tableName.Replace("TB_", "");
            var sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using FS.BLL;");
            sb.AppendLine("using FS.DAL;");
            sb.AppendLine("using FS.DAL.Models;");
            sb.AppendLine("using System.Web.Mvc;");
            sb.AppendLine("namespace  FS.MVC.Areas.CMS.Controllers");
            sb.AppendLine("{");
            sb.AppendLine("   public class "+entityName+"Controller : Controller");
            sb.AppendLine("  {");
            //列表
            sb.AppendLine("       public ActionResult "+ entityName + "()");
            sb.AppendLine("       {");
            sb.AppendLine("              var list="+entityName+"Service.Get"+entityName+"List();");
            sb.AppendLine("              return View(list);");
            sb.AppendLine("       }");
            //新增
            sb.AppendLine("       [HttpPost]");
            sb.AppendLine("       public void Save"+ entityName + "(" + entityName + " entity)");
            sb.AppendLine("       {");
            sb.AppendLine("              if(entity.ID>0)");
            sb.AppendLine("              {");
            sb.AppendLine("                  "+ entityName + "Service.Update"+ entityName + "(entity);");
            sb.AppendLine("              }");
            sb.AppendLine("             else");
            sb.AppendLine("              {");
            sb.AppendLine("                  " + entityName + "Service.Insert" + entityName + "(entity);");
            sb.AppendLine("              }");
            sb.AppendLine("       }");
            sb.AppendLine("  }");
            sb.AppendLine("}");
            IOHelper.WriteInfoToFile(sb.ToString(), ControllerPath + "\\" + entityName + "Controller.cs");
        }
        private static void ServiceFile(string tableName)
        {
            var entityName = tableName.Replace("TB_", "");
            var sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using FS.DAL;");
            sb.AppendLine("using FS.DAL.Models;");
            sb.AppendLine("namespace FS.BLL");
            sb.AppendLine("{");
            sb.AppendLine("  public class " + entityName + "Service");
            sb.AppendLine("  {");
            //Insert方法
            sb.AppendLine("       public static int Insert"+entityName+"("+ entityName + " entity)");
            sb.AppendLine("       {");
            sb.AppendLine("              return "+ entityName + "IService.Insert"+ entityName + "(entity);");
            sb.AppendLine("       }");
            //Delete
            sb.AppendLine("       public static int Delete" + entityName + "(int ID)");
            sb.AppendLine("       {");
            sb.AppendLine("              return " + entityName + "IService.Delete" + entityName + "(ID);");
            sb.AppendLine("       }");
            //Update
            sb.AppendLine("       public static int Update" + entityName + "(" + entityName + " entity)");
            sb.AppendLine("       {");
            sb.AppendLine("              return " + entityName + "IService.Update" + entityName + "(entity);");
            sb.AppendLine("       }");
            //GetList
            sb.AppendLine("       public static List<" + entityName + "> Get" + entityName + "List()");
            sb.AppendLine("       {");
            sb.AppendLine("              return " + entityName + "IService.Get" + entityName + "List();");
            sb.AppendLine("       }");
            //GetListByID
            sb.AppendLine("       public static " + entityName + " Get" + entityName + "ByID(int ID)");
            sb.AppendLine("       {");
            sb.AppendLine("              return " + entityName + "IService.Get" + entityName + "ByID(ID);");
            sb.AppendLine("       }");
            sb.AppendLine("  }");
            sb.AppendLine("}");
            IOHelper.WriteInfoToFile(sb.ToString(), ServicePath + "\\" + entityName + "Service.cs");
        }

        private static void IServiceFile(string tableName)
        {
           var  entityName = tableName.Replace("TB_", "");
            var tableRows = allTableColumns.Select(" TableName='" + tableName + "' and ColumnsName not in ('ID')");// GetTableColumnsNoID(tableName);
            var sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using Dapper;");
            sb.AppendLine("using System.Data;");
            sb.AppendLine("using FS.DAL.Models;");
            sb.AppendLine("namespace FS.DAL");
            sb.AppendLine("{");
            sb.AppendLine("  public class " + entityName + "IService");
            sb.AppendLine("  {");
            //Insert方法
            sb.AppendLine("       public static int Insert"+ entityName + "("+ entityName + " entity)");
            sb.AppendLine("       {");
            sb.AppendLine("           var result = ConfigHelper.GetConn().ExecuteScalar(@\"");
            sb.AppendLine("           Insert into " + tableName + " values(");
            for (var i = 0; i < tableRows.Count(); i++)
            {
                if (i > 0) sb.Append(",");
                sb.Append("@"+ tableRows[i]["ColumnsName"]);
            }
            sb.Append(";select  @@IDENTITY;\"");
            sb.AppendLine("             ,entity);");
            sb.AppendLine("              return Convert.ToInt32(result);");
            sb.AppendLine("       }");
            //Delete
            sb.AppendLine("       public static int Delete" + entityName + "(int ID)");
            sb.AppendLine("       {");
            sb.AppendLine("            var result = ConfigHelper.GetConn().Execute(@\"");
            sb.AppendLine("            Delete from TB_CurrentShares where ID=@ID\"");
            sb.AppendLine("            , new { ID = ID });");
            sb.AppendLine("             return result;");
            sb.AppendLine("       }");
            //Update
            sb.AppendLine("       public static int Update" + entityName + "(" + entityName + " entity)");
            sb.AppendLine("       {");
            sb.AppendLine("           var result = ConfigHelper.GetConn().Execute(@\"");
            sb.AppendLine("           update "+tableName+" set ");
            for (var i = 0; i < tableRows.Count(); i++)
            {
                if (i > 0) sb.Append(",");
                sb.Append(tableRows[i]["ColumnsName"]+"=@" + tableRows[i]["ColumnsName"]);
            }
            sb.AppendLine("\"            ,entity);");
            sb.AppendLine("              return result;");
            sb.AppendLine("       }");
            //GetList
            sb.AppendLine("       public static List<"+entityName+"> Get"+ entityName + "List()");
            sb.AppendLine("       {");
            sb.AppendLine("            List<"+ entityName + "> "+ entityName + "List = new List<"+ entityName + ">();");
            sb.AppendLine("            using (IDbConnection conn = ConfigHelper.GetConn())");
            sb.AppendLine("            {");
            sb.AppendLine("             string sqlCommandText = @\"select * from "+tableName+"\";");
            sb.AppendLine("              " + entityName + "List = conn.Query<" + entityName+">(sqlCommandText).ToList();");
            sb.AppendLine("            }");
            sb.AppendLine("            return  " + entityName + "List;");
            sb.AppendLine("       }");
            //GetListByID
            sb.AppendLine("       public static "+entityName+" Get"+ entityName+ "ByID(int ID)");
            sb.AppendLine("       {");
            sb.AppendLine("            List<" + entityName + "> " + entityName + "List = new List<" + entityName + ">();");
            sb.AppendLine("            using (IDbConnection conn = ConfigHelper.GetConn())");
            sb.AppendLine("            {");
            sb.AppendLine("             string sqlCommandText = @\"select * from " + tableName + "\";");
            sb.AppendLine("              " + entityName + "List = conn.Query<" + entityName + ">(sqlCommandText).ToList();");
            sb.AppendLine("            }");
            sb.AppendLine("            return " + entityName + "List.Count != 0 ? " + entityName + "List.FirstOrDefault() : null;");
            sb.AppendLine("       }");
            sb.AppendLine("  }");
            sb.AppendLine("}");
            IOHelper.WriteInfoToFile(sb.ToString(), IServicePath + "\\"+entityName + "IService.cs");
        }
        /// <summary>
        /// 生成models
        /// </summary>
        /// <param name="tableName"></param>
        private static void ModelFile(string tableName)
        {
            var sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Linq;");
            sb.AppendLine("using System.Text;");
            sb.AppendLine("using FS.Framework;");
            sb.AppendLine("namespace FS.DAL.Models");
            sb.AppendLine("{");
            sb.AppendLine("  public class "+tableName.Replace("TB_","")+"");
            sb.AppendLine("  {");
          //  var tableColumns = GetTableColumns(tableName);
            var tableRows = allTableColumns.Select(" TableName='" + tableName + "'");// GetTableColumnsNoID(tableName);

            for (var i = 0; i < tableRows.Count(); i++)
            {
                string columnType = tableRows[i]["ColumnType"].ToString();
                switch (columnType)
                {
                    case "int":
                    case "uniqueidentifier":
                        columnType = "int";
                        break;
                    case "nvarchar":
                    case "varchar":
                    case "varbinar":
                    case "varbinary":
                    case "binary":
                        columnType = "string";
                        break;
                    case "decimal":
                        break;
                    case "date":
                    case "datetime2":
                    case "datetime":
                        columnType = "DateTime";
                        break;
                    case "bit":
                        columnType = "bool";
                        break;
                    default:
                        columnType = "string";
                        break;
                }
                sb.AppendLine("");
                string desc = tableRows[i]["Description"] != DBNull.Value ? tableRows[i]["Description"].ToString() : "";
                if (!string.IsNullOrEmpty(desc))
                {
                    desc= desc.Replace("\n","").Replace("\n", "").Replace("\n", "").Replace("\n", "").Replace("\r", "").Replace("\r", "").Replace("\r", "").Replace("\r", "");
                }
                sb.AppendLine("    [ColumnDescription(\""+ desc + "\")]");
                var columnsname = tableRows[i]["ColumnsName"].ToString().Trim().Replace(" ", "").Replace("__$", "_");
                if (columnsname == tableName.Replace("TB_", ""))
                {
                    columnsname = columnsname + "1";
                }
                sb.AppendLine("    public "+ columnType + " "+ columnsname + " { get; set; }");
            }
            sb.AppendLine("  }");
            sb.AppendLine("}");
            IOHelper.WriteInfoToFile(sb.ToString(), modelPath + "\\"+ tableName.Replace("TB_", "") + ".cs");
        }
        #endregion

        #region 读取表结构
        /// <summary>
        /// 读取库中所有的表名称
        /// </summary>
        /// <returns></returns>
        private static DataTable GetTableName()
        {
            var sql = @"SELECT name
FROM     Tidebuy..sysobjects
WHERE    xtype = 'U'
ORDER BY name";
           return SqlDbHelper.ExecuteDataTable(sql);
        }
        /// <summary>
        /// 读取表字段
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        private static DataTable GetTableColumns(string tableName)
        {
            var sql = @"SELECT 
            TableName = OBJECT_NAME(c.object_id), 
            ColumnsName = c.name, 
            Description = ex.value, 
            ColumnType=t.name, 
            Length=c.max_length 
            FROM 
            sys.columns c 
            LEFT OUTER JOIN 
            sys.extended_properties ex 
            ON 
            ex.major_id = c.object_id 
            AND ex.minor_id = c.column_id 
            AND ex.name = 'MS_Description' 
            left outer join 
            systypes t 
            on c.system_type_id=t.xtype 
            WHERE 
            OBJECTPROPERTY(c.object_id, 'IsMsShipped')=0 
            AND OBJECT_NAME(c.object_id) ='"+tableName+@"'
            and t.name!='sysname'";
            return SqlDbHelper.ExecuteDataTable(sql);
        }
        private static DataTable GetTableColumns()
        {
            var sql = @"SELECT 
            TableName = OBJECT_NAME(c.object_id), 
            ColumnsName = c.name, 
            Description = ex.value, 
            ColumnType=t.name, 
            Length=c.max_length 
            FROM 
            sys.columns c 
            LEFT OUTER JOIN 
            sys.extended_properties ex 
            ON 
            ex.major_id = c.object_id 
            AND ex.minor_id = c.column_id 
            AND ex.name = 'MS_Description' 
            left outer join 
            systypes t 
            on c.system_type_id=t.xtype 
            WHERE 
            OBJECTPROPERTY(c.object_id, 'IsMsShipped')=0 
            and t.name!='sysname'";
            return SqlDbHelper.ExecuteDataTable(sql);
        }
        /// <summary>
        /// 不包括主键ID
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        private static DataTable GetTableColumnsNoID(string tableName)
        {
            var sql = @"SELECT 
            TableName = OBJECT_NAME(c.object_id), 
            ColumnsName = c.name, 
            Description = ex.value, 
            ColumnType=t.name, 
            Length=c.max_length 
            FROM 
            sys.columns c 
            LEFT OUTER JOIN 
            sys.extended_properties ex 
            ON 
            ex.major_id = c.object_id 
            AND ex.minor_id = c.column_id 
            AND ex.name = 'MS_Description' 
            left outer join 
            systypes t 
            on c.system_type_id=t.xtype 
            WHERE 
            OBJECTPROPERTY(c.object_id, 'IsMsShipped')=0 
            AND OBJECT_NAME(c.object_id) ='" + tableName + @"'
            and t.name!='sysname'";
            return SqlDbHelper.ExecuteDataTable(sql);
        }
        #endregion
    }
}
