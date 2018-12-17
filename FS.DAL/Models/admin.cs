using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class admin
  {

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public string Permission { get; set; }

    [ColumnDescription("")]
    public int DeptID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public int IsManager { get; set; }

    [ColumnDescription("")]
    public string WorkContent { get; set; }

    [ColumnDescription("")]
    public string Num { get; set; }

    [ColumnDescription("")]
    public string PermissionID { get; set; }

    [ColumnDescription("")]
    public string PerID { get; set; }

    [ColumnDescription("")]
    public int UserState { get; set; }

    [ColumnDescription("")]
    public string VerifyNum { get; set; }

    [ColumnDescription("")]
    public string Phone { get; set; }

    [ColumnDescription("")]
    public string CategoryID { get; set; }

    [ColumnDescription("")]
    public string LanguageID { get; set; }

    [ColumnDescription("")]
    public string Sites { get; set; }

    [ColumnDescription("")]
    public string NickName { get; set; }
  }
}
