using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ApplyOrderRefundAddress
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string CountryIDs { get; set; }

    [ColumnDescription("")]
    public string CompanyName { get; set; }

    [ColumnDescription("")]
    public string CompanAddress { get; set; }

    [ColumnDescription("")]
    public string DetailedContactInformation { get; set; }
  }
}
