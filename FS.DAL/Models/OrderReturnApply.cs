using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class OrderReturnApply
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int OrderBillID { get; set; }

    [ColumnDescription("包裹号")]
    public string PackNo { get; set; }

    [ColumnDescription("物流号")]
    public string ShipNo { get; set; }

    [ColumnDescription("类型。1：换货，2：退货，3：未妥投，4：用户退回，5：包裹丢失")]
    public int Type { get; set; }

    [ColumnDescription("退货原因，备注")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("销售ID")]
    public int AdminID { get; set; }

    [ColumnDescription("处理人email")]
    public string ProcessName { get; set; }

    [ColumnDescription("质检结果")]
    public string CheckResult { get; set; }

    [ColumnDescription("是否收货")]
    public int IsReceipt { get; set; }

    [ColumnDescription("状态：1、正常/未发货 0、删除或异常、2、海外仓已收货")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int ReturnCount { get; set; }

    [ColumnDescription("")]
    public string Reason { get; set; }

    [ColumnDescription("")]
    public DateTime MissageTime { get; set; }

    [ColumnDescription("")]
    public int Warehouse { get; set; }

    [ColumnDescription("")]
    public int ForeighIsReceipt { get; set; }

    [ColumnDescription("")]
    public int HandleState { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public DateTime HandleTime { get; set; }

    [ColumnDescription("")]
    public int ForeignUserID { get; set; }
  }
}
