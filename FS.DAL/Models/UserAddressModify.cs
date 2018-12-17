using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class UserAddressModify
  {

    [ColumnDescription("")]
    public int ID { get; set; }

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
    public string FirstName { get; set; }

    [ColumnDescription("")]
    public string LastName { get; set; }

    [ColumnDescription("")]
    public string NewAddRessUserName { get; set; }

    [ColumnDescription("")]
    public int NewCountryID { get; set; }

    [ColumnDescription("")]
    public string NewCode { get; set; }

    [ColumnDescription("")]
    public string NewPhone { get; set; }

    [ColumnDescription("")]
    public string NewAddressLine1 { get; set; }

    [ColumnDescription("")]
    public string NewAddressLine2 { get; set; }

    [ColumnDescription("")]
    public string NewProvince { get; set; }

    [ColumnDescription("")]
    public string NewCity { get; set; }

    [ColumnDescription("")]
    public string NewFirstName { get; set; }

    [ColumnDescription("")]
    public string NewLastName { get; set; }

    [ColumnDescription("")]
    public int CreateUserID { get; set; }

    [ColumnDescription("")]
    public string CreateTime { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public int ConfirmUserID { get; set; }

    [ColumnDescription("")]
    public string ConfirmTime { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }
  }
}
