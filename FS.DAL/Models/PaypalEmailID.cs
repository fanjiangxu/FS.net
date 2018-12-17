using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PaypalEmailID
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int Num { get; set; }

    [ColumnDescription("")]
    public int UID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }
  }
}
