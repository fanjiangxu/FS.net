using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Rule_Seo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("WWW,M,APP")]
    public int SiteType { get; set; }

    [ColumnDescription("0:不提醒；1:邮箱提醒；2:短信提醒；3：邮箱、短信提醒")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public string Phone { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("对应 TB_Type_Seo  表ID   ")]
    public int TypeID { get; set; }

    [ColumnDescription("0:禁用（不判断该规则）；1:启用（默认）")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }
  }
}
