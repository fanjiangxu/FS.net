using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SearchWordsWeight
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public string Words { get; set; }

    [ColumnDescription("")]
    public int WordsWeight { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public int CreateUser { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string SynonymWord { get; set; }

    [ColumnDescription("")]
    public int LanguageID { get; set; }
  }
}
