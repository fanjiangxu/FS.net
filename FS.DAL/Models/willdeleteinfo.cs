using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class willdeleteinfo
  {

    [ColumnDescription("")]
    public string 品类 { get; set; }

    [ColumnDescription("")]
    public string ID { get; set; }

    [ColumnDescription("")]
    public string SPUID { get; set; }

    [ColumnDescription("")]
    public string 规格尺寸 { get; set; }

    [ColumnDescription("")]
    public string SKUID { get; set; }

    [ColumnDescription("")]
    public string 选款后剩余数量 { get; set; }

    [ColumnDescription("")]
    public string 采购成本 { get; set; }

    [ColumnDescription("")]
    public string 供应商 { get; set; }

    [ColumnDescription("")]
    public string 重量 { get; set; }

    [ColumnDescription("")]
    public string 库存 { get; set; }

    [ColumnDescription("")]
    public string F11 { get; set; }
  }
}
