using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class tb_tempProduct_presale
  {

    [ColumnDescription("")]
    public DateTime endtime { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public decimal SalePrice { get; set; }
  }
}
