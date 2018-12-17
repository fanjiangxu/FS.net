using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class BrandMeta
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string BrandKey { get; set; }

    [ColumnDescription("")]
    public string TitleTags { get; set; }

    [ColumnDescription("")]
    public string KeywordsTags { get; set; }

    [ColumnDescription("")]
    public string DescriptionTags { get; set; }

    [ColumnDescription("")]
    public string Description { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
