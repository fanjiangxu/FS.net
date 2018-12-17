using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ErrorOrder_Pingtai
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string PTOrderID { get; set; }

    [ColumnDescription("")]
    public int StoreID { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public DateTime HandDateTime { get; set; }

    [ColumnDescription("")]
    public int HandUserID { get; set; }
  }
}
