using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PDFCategory
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int ParentID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int adminid { get; set; }

    [ColumnDescription("")]
    public string TitleTags { get; set; }

    [ColumnDescription("")]
    public string KeywordsTags { get; set; }

    [ColumnDescription("")]
    public string DescriptionTags { get; set; }

    [ColumnDescription("")]
    public string Description { get; set; }
  }
}
