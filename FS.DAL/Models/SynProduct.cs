using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SynProduct
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string Category { get; set; }

    [ColumnDescription("")]
    public string SiteCategory { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int NewSiteID { get; set; }

    [ColumnDescription("")]
    public string SynWhere { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public string newShipping { get; set; }

    [ColumnDescription("")]
    public string newState { get; set; }

    [ColumnDescription("")]
    public int isUseChangePrice { get; set; }

    [ColumnDescription("")]
    public DateTime addDate { get; set; }

    [ColumnDescription("")]
    public int addUser { get; set; }
  }
}
