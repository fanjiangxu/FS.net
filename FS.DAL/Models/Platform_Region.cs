using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Platform_Region
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int RegionID { get; set; }

    [ColumnDescription("")]
    public string RegionName { get; set; }

    [ColumnDescription("")]
    public string ApiUrl { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public string CreateUserName { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string UpdateUserName { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public string MarketplaceId { get; set; }

    [ColumnDescription("")]
    public int Region { get; set; }

    [ColumnDescription("")]
    public bool IsShareStock { get; set; }
  }
}
