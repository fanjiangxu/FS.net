using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Account_UserDataAccessAssign
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string Data { get; set; }

    [ColumnDescription("")]
    public int DataAccessType { get; set; }

    [ColumnDescription("")]
    public DateTime ExpiredTime { get; set; }

    [ColumnDescription("")]
    public bool IsEnable { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public string CreateUserName { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string UpdateUserName { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }
  }
}
