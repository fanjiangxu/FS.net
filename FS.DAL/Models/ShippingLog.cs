using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ShippingLog
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public string TableName { get; set; }

    [ColumnDescription("")]
    public DateTime AdddDate { get; set; }

    [ColumnDescription("")]
    public int AdminId { get; set; }

    [ColumnDescription("")]
    public string Operating { get; set; }

    [ColumnDescription("")]
    public string ThePage { get; set; }
  }
}
