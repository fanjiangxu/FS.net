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
    public class ElemaHelper
    {
        public static int InsertElema(Elema entity)
        {
            var result = ConfigHelper.GetConn().ExecuteScalar("Insert into TB_Elema values (@MobileID,@UserName,@Password, @IsValid);select  @@IDENTITY;",
                                   new  { MobileID = entity.MobileID,UserName=entity.UserName,Password=entity.Password, IsValid = entity.IsValid });
            return Convert.ToInt32(result);
        }
        public static int DeleteElema(int ID)
        {
            var result = ConfigHelper.GetConn().Execute("Delete from TB_Elema where ID=@ID",
                                   new { ID=ID });
            return result;
        }
        public static int UpdateElema(Elema entity)
        {
            var result = ConfigHelper.GetConn().Execute("update TB_Elema set MobileID=@MobileID,  UserName=@UserName, Password=@Password,IsValid=@IsValid where ID=@ID",
                                 new { MobileID = entity.MobileID, UserName = entity.UserName, Password = entity.Password, IsValid = entity.IsValid });
            return result;
        }
    }
}
