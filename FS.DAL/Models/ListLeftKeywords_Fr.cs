using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ListLeftKeywords_Fr
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public string keyword { get; set; }

    [ColumnDescription("")]
    public string searchCount { get; set; }

    [ColumnDescription("")]
    public string competition { get; set; }

    [ColumnDescription("")]
    public int weight { get; set; }

    [ColumnDescription("")]
    public string url { get; set; }

    [ColumnDescription("")]
    public DateTime addTime { get; set; }

    [ColumnDescription("")]
    public int categoryId { get; set; }

    [ColumnDescription("")]
    public int siteId { get; set; }

    [ColumnDescription("")]
    public int cationIndex { get; set; }
  }
}
