using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UsersInfo
  {

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public int CountryID { get; set; }

    [ColumnDescription("")]
    public string CountryName { get; set; }

    [ColumnDescription("")]
    public int Vsits { get; set; }

    [ColumnDescription("")]
    public int Accesstime { get; set; }

    [ColumnDescription("")]
    public string BuyCategoryIDs { get; set; }

    [ColumnDescription("")]
    public string SeeCategoryIDs { get; set; }

    [ColumnDescription("")]
    public DateTime Lasttime { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int KID { get; set; }

    [ColumnDescription("")]
    public string Gender { get; set; }

    [ColumnDescription("")]
    public string RegBirthdayMonth { get; set; }
  }
}
