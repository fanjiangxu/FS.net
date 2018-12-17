using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Brand
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Url { get; set; }

    [ColumnDescription("")]
    public string Image { get; set; }

    [ColumnDescription("")]
    public string CnName { get; set; }

    [ColumnDescription("")]
    public string EnName { get; set; }

    [ColumnDescription("")]
    public string Country { get; set; }

    [ColumnDescription("")]
    public string CreateAge { get; set; }

    [ColumnDescription("")]
    public string CreateMan { get; set; }

    [ColumnDescription("")]
    public string CurrentDesigner { get; set; }

    [ColumnDescription("")]
    public string OfficialWebsite { get; set; }

    [ColumnDescription("")]
    public string LikeCreate { get; set; }

    [ColumnDescription("")]
    public int URLID { get; set; }

    [ColumnDescription("")]
    public string parentID { get; set; }
  }
}
