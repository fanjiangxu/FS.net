using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class FeedbackImage
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public DateTime CreateTime { get; set; }

    [ColumnDescription("")]
    public string ImageUrl { get; set; }

    [ColumnDescription("")]
    public int FeedbackGUID { get; set; }
  }
}
