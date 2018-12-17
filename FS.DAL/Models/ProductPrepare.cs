using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductPrepare
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string PmsCategoryIDs { get; set; }

    [ColumnDescription("")]
    public string CategoryIDs { get; set; }

    [ColumnDescription("")]
    public string ProductIDs { get; set; }

    [ColumnDescription("")]
    public string ProductNo { get; set; }

    [ColumnDescription("")]
    public string PrepareDateOld { get; set; }

    [ColumnDescription("")]
    public string PrepareDateNew { get; set; }

    [ColumnDescription("")]
    public DateTime StartTime { get; set; }

    [ColumnDescription("")]
    public DateTime RecoverTime { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string CreateUserEmail { get; set; }

    [ColumnDescription("")]
    public int Status { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public int ProductState { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateRecoverTime { get; set; }

    [ColumnDescription("")]
    public string SPUID { get; set; }

    [ColumnDescription("")]
    public string DebarSPUID { get; set; }

    [ColumnDescription("")]
    public string DebarProductIDs { get; set; }

    [ColumnDescription("")]
    public bool IsPerpetual { get; set; }
  }
}
