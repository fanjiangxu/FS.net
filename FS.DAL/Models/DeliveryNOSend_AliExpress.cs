using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class DeliveryNOSend_AliExpress
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public bool IsSuccess { get; set; }

    [ColumnDescription("")]
    public string Message { get; set; }

    [ColumnDescription("")]
    public string SendData { get; set; }
  }
}
