using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class WishJobLog
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string job_id { get; set; }

    [ColumnDescription("")]
    public int total_count { get; set; }

    [ColumnDescription("")]
    public int processed_count { get; set; }

    [ColumnDescription("")]
    public string download_link { get; set; }

    [ColumnDescription("")]
    public DateTime end_run_time { get; set; }

    [ColumnDescription("")]
    public DateTime start_run_time { get; set; }

    [ColumnDescription("")]
    public DateTime created_date { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int HandleState { get; set; }

    [ColumnDescription("")]
    public string LocalPath { get; set; }

    [ColumnDescription("")]
    public int ShopID { get; set; }
  }
}
