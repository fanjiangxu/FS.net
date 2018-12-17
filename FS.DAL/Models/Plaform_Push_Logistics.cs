using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Plaform_Push_Logistics
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int PingTaiID { get; set; }

    [ColumnDescription("")]
    public int StoreID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public string Tx { get; set; }

    [ColumnDescription("")]
    public string OldExpressType { get; set; }

    [ColumnDescription("")]
    public string NewExpresstYPE { get; set; }

    [ColumnDescription("")]
    public string OldShipNo { get; set; }

    [ColumnDescription("")]
    public string NewShipNo { get; set; }

    [ColumnDescription("")]
    public string SendType { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int PushUserID { get; set; }

    [ColumnDescription("")]
    public int PushState { get; set; }

    [ColumnDescription("")]
    public int HandleUserID { get; set; }

    [ColumnDescription("")]
    public int HandleState { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }
  }
}
