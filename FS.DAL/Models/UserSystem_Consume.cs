using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UserSystem_Consume
  {

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public decimal Consume { get; set; }

    [ColumnDescription("")]
    public DateTime LastUpdate { get; set; }

    [ColumnDescription("")]
    public int ID { get; set; }
  }
}
