using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class tb_ProductSizePropertyVal
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SizeID { get; set; }

    [ColumnDescription("")]
    public int PropertyID { get; set; }

    [ColumnDescription("")]
    public int ValueOne { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int ValueTwo { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }
  }
}
