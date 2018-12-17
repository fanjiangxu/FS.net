using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UserSendAddressOrder
  {

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int AddressID { get; set; }

    [ColumnDescription("")]
    public string AddRessUserName { get; set; }

    [ColumnDescription("")]
    public int CountryID { get; set; }

    [ColumnDescription("")]
    public string Code { get; set; }

    [ColumnDescription("")]
    public string Phone { get; set; }

    [ColumnDescription("")]
    public string AddressLine1 { get; set; }

    [ColumnDescription("")]
    public string AddressLine2 { get; set; }

    [ColumnDescription("")]
    public string Province { get; set; }

    [ColumnDescription("")]
    public string City { get; set; }

    [ColumnDescription("")]
    public int Type { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string FirstName { get; set; }

    [ColumnDescription("")]
    public string LastName { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public int KID { get; set; }
  }
}
