using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class NativePayMapping
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public int PaymentId { get; set; }

    [ColumnDescription("")]
    public string PaymentName { get; set; }

    [ColumnDescription("")]
    public int CountryId { get; set; }

    [ColumnDescription("")]
    public string CountryName { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public string Currency { get; set; }
  }
}
