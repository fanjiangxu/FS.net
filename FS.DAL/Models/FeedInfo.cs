using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class FeedInfo
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string FeedName { get; set; }

    [ColumnDescription("")]
    public int TypeID { get; set; }

    [ColumnDescription("")]
    public int CategoryID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int AdminID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string GoogleCategory { get; set; }

    [ColumnDescription("")]
    public string ProductSize { get; set; }

    [ColumnDescription("")]
    public int LanguageID { get; set; }

    [ColumnDescription("")]
    public int GoogleCategoryID { get; set; }

    [ColumnDescription("")]
    public string Gender { get; set; }
  }
}
