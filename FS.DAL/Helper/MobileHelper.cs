using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FS.DAL.Model;

namespace FS.DAL
{
    public class MobileHelper
    {
        public static int InsertMobile(Mobile entity)
        {
            var result = ConfigHelper.GetConn().ExecuteScalar("Insert into TB_Mobile values (@Mobile, @IsValid);select  @@IDENTITY;",
                                   new  { Mobile = entity.MobileField, IsValid = entity.IsValid });
            return Convert.ToInt32(result);
        }
        public static int DeleteMobile(int ID)
        {
            var result = ConfigHelper.GetConn().Execute("Delete from TB_Mobile where ID=@ID",
                                   new { ID=ID });
            return result;
        }
        public static int UpdateMobile(Mobile entity)
        {
            var result = ConfigHelper.GetConn().Execute("update TB_Mobile set Mobile=@Mobile, IsValid=@IsValid where ID=@ID",
                                   new { Mobile = entity.MobileField, IsValid = entity.IsValid,ID=entity.ID });
            return result;
        }
    }
}
