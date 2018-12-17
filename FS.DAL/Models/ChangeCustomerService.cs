using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ChangeCustomerService
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public int OldServiceID { get; set; }

    [ColumnDescription("")]
    public int NewServiceID { get; set; }

    [ColumnDescription("")]
    public DateTime EditDate { get; set; }

    [ColumnDescription("")]
    public int EditUserID { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string UserEmail { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateDate { get; set; }
  }
}
