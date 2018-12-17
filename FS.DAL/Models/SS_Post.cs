using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SS_Post
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public int ParentID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string Images { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string PID { get; set; }

    [ColumnDescription("")]
    public int CategoryID { get; set; }

    [ColumnDescription("")]
    public string TagsID { get; set; }

    [ColumnDescription("")]
    public string Descriptions { get; set; }

    [ColumnDescription("")]
    public string Height { get; set; }

    [ColumnDescription("")]
    public string Weights { get; set; }

    [ColumnDescription("")]
    public string Size { get; set; }
  }
}
