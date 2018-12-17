using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class HD_ArticleImg
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ArticleID { get; set; }

    [ColumnDescription("")]
    public int IsNewUpload { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string Image { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }
  }
}
