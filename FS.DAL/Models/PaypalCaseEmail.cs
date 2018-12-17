using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PaypalCaseEmail
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UID { get; set; }

    [ColumnDescription("")]
    public DateTime SendDate { get; set; }

    [ColumnDescription("")]
    public string SendFrom { get; set; }

    [ColumnDescription("")]
    public string TX { get; set; }

    [ColumnDescription("")]
    public string BuyerEmail { get; set; }

    [ColumnDescription("")]
    public string Body { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public DateTime DoDate { get; set; }
  }
}
