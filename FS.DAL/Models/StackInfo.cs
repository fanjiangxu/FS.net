using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class StackInfo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string CNName { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string CNAddress { get; set; }

    [ColumnDescription("")]
    public string Address { get; set; }

    [ColumnDescription("")]
    public string CNSimpleAddress { get; set; }

    [ColumnDescription("")]
    public string SimpleAddress { get; set; }

    [ColumnDescription("")]
    public string Consignee { get; set; }

    [ColumnDescription("")]
    public string PhoneNumber { get; set; }

    [ColumnDescription("")]
    public string PostalCode { get; set; }
  }
}
