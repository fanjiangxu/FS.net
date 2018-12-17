using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class fact_cate_sale
  {

    [ColumnDescription("")]
    public string day { get; set; }

    [ColumnDescription("")]
    public string cid { get; set; }

    [ColumnDescription("")]
    public int count { get; set; }

    [ColumnDescription("")]
    public decimal revenue { get; set; }
  }
}
