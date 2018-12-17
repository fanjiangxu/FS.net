using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class WeddingIdea
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int AdminId { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public string PDFCategoryID { get; set; }

    [ColumnDescription("")]
    public string PDFUrl { get; set; }

    [ColumnDescription("")]
    public string PDFImage { get; set; }

    [ColumnDescription("")]
    public int TweetCount { get; set; }

    [ColumnDescription("")]
    public int FshareCounT { get; set; }

    [ColumnDescription("")]
    public int PinitCount { get; set; }

    [ColumnDescription("")]
    public int CommentCount { get; set; }

    [ColumnDescription("")]
    public string DownlodCount { get; set; }

    [ColumnDescription("")]
    public int ToVviewCount { get; set; }

    [ColumnDescription("")]
    public int ToSaveCount { get; set; }

    [ColumnDescription("")]
    public int ToBlackCount { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int Reviews { get; set; }

    [ColumnDescription("")]
    public int GoogleCount { get; set; }

    [ColumnDescription("")]
    public int LinkedInCount { get; set; }

    [ColumnDescription("")]
    public int TweetTrur { get; set; }

    [ColumnDescription("")]
    public int FshareTrur { get; set; }

    [ColumnDescription("")]
    public int PinitTrur { get; set; }

    [ColumnDescription("")]
    public int CommentTrur { get; set; }

    [ColumnDescription("")]
    public int GoogleTrur { get; set; }

    [ColumnDescription("")]
    public int LinkedInTrur { get; set; }

    [ColumnDescription("")]
    public int ToSaveCountTrue { get; set; }

    [ColumnDescription("")]
    public int ToBlackCountTrue { get; set; }
  }
}
