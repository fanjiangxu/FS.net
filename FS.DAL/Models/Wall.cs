using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Wall
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public int Xing { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public string Tool { get; set; }

    [ColumnDescription("")]
    public string Countries { get; set; }

    [ColumnDescription("")]
    public int Comments { get; set; }

    [ColumnDescription("")]
    public decimal Score { get; set; }

    [ColumnDescription("")]
    public string Wall1 { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int Siteid { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int AddAdminID { get; set; }

    [ColumnDescription("")]
    public string Platform { get; set; }
  }
}
