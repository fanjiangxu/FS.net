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
    public class MeituanHelper
    {
        public static int InsertMeituan(Meituan entity)
        {
            var result = ConfigHelper.GetConn().ExecuteScalar("Insert into TB_Meituan values (@MobileID,@UserName,@Password, @IsValid);select  @@IDENTITY;",
                                   new  { MobileID = entity.MobileID,UserName=entity.UserName,Password=entity.Password, IsValid = entity.IsValid });
            return Convert.ToInt32(result);
        }
        public static int DeleteMeituan(int ID)
        {
            var result = ConfigHelper.GetConn().Execute("Delete from TB_Meituan where ID=@ID",
                                   new { ID=ID });
            return result;
        }
        public static int UpdateMeituan(Meituan entity)
        {
            var result = ConfigHelper.GetConn().Execute("update TB_Meituan set MobileID=@MobileID,  UserName=@UserName, Password=@Password,IsValid=@IsValid where ID=@ID",
                                 new { MobileID = entity.MobileID, UserName = entity.UserName, Password = entity.Password, IsValid = entity.IsValid });
            return result;
        }
    }
}
