using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductStock_ScmSku_PmsSku_Mapping
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ScmSkuID { get; set; }

    [ColumnDescription("")]
    public int ScmSpuID { get; set; }

    [ColumnDescription("")]
    public int PmsSkuID { get; set; }

    [ColumnDescription("")]
    public int PmsSpuID { get; set; }

    [ColumnDescription("")]
    public string Message { get; set; }

    [ColumnDescription("")]
    public bool IsEnable { get; set; }

    [ColumnDescription("")]
    public string DisableReason { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string CreateUserName { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public string UPdateUserName { get; set; }
  }
}
