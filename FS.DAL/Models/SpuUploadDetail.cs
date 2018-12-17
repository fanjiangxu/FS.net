using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SpuUploadDetail
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }

    [ColumnDescription("")]
    public string PinTaiID { get; set; }

    [ColumnDescription("")]
    public string SPU { get; set; }

    [ColumnDescription("")]
    public string ErrMessage { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }
  }
}
