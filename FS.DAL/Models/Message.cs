using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Message
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string Content { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string Phone { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public int AdminID { get; set; }

    [ColumnDescription("")]
    public string Images { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public DateTime replyDate { get; set; }

    [ColumnDescription("")]
    public int IsComplaint { get; set; }

    [ColumnDescription("")]
    public int Language { get; set; }

    [ColumnDescription("")]
    public int replyCount { get; set; }

    [ColumnDescription("")]
    public int replyAdminID { get; set; }

    [ColumnDescription("")]
    public int Country { get; set; }

    [ColumnDescription("客户性质。默认(1)：一般消费者：1；零售商：2；公司采购：3；网店代沟：4")]
    public int CustomerType { get; set; }
  }
}
