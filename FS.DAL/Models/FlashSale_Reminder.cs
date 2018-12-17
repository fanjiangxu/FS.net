using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class FlashSale_Reminder
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("0:刚添加    1:已发送邮件    ")]
    public int State { get; set; }

    [ColumnDescription("")]
    public DateTime SendMailTime { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public DateTime ActiveBeginTime { get; set; }

    [ColumnDescription("")]
    public DateTime ActiveEndTime { get; set; }
  }
}
