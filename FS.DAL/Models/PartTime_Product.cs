using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PartTime_Product
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public string TranTitle { get; set; }

    [ColumnDescription("")]
    public string ChineseDescription { get; set; }

    [ColumnDescription("")]
    public string Description { get; set; }

    [ColumnDescription("")]
    public string Images { get; set; }

    [ColumnDescription("翻译状态：0,待翻译 1,待审核 2,待结算 3,已结算 -1,审核不通过 , -3已取消任务")]
    public int TranState { get; set; }

    [ColumnDescription("审核不通过原因")]
    public string NoSuccessReason { get; set; }

    [ColumnDescription("翻译时间")]
    public DateTime CommitTime { get; set; }

    [ColumnDescription("审核管理员")]
    public int AuditAdmin { get; set; }

    [ColumnDescription("审核时间")]
    public DateTime AuditTime { get; set; }

    [ColumnDescription("翻译次数")]
    public int TranTimes { get; set; }

    [ColumnDescription("结算时间")]
    public DateTime SettlementTime { get; set; }

    [ColumnDescription("结算管理员")]
    public int SettlementAdmin { get; set; }

    [ColumnDescription("")]
    public bool IsNewProperty { get; set; }

    [ColumnDescription("")]
    public int ProductPropertyMappingID { get; set; }

    [ColumnDescription("产品属性值")]
    public string PropertyValues { get; set; }

    [ColumnDescription("产品归属人")]
    public int BelongUser { get; set; }

    [ColumnDescription("分配人")]
    public int AllocationAdmin { get; set; }

    [ColumnDescription("分配时间")]
    public DateTime AllocationDate { get; set; }

    [ColumnDescription("日志")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public bool IsFirstAuditSuccess { get; set; }
  }
}
