using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Pay_Account
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string APIUsername { get; set; }

    [ColumnDescription("")]
    public string APIPassword { get; set; }

    [ColumnDescription("")]
    public string APISignature { get; set; }
  }
}
