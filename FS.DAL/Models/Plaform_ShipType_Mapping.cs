using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Plaform_ShipType_Mapping
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int PingTaiID { get; set; }

    [ColumnDescription("")]
    public string ServerLevel { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string CNName { get; set; }

    [ColumnDescription("")]
    public string ShortName { get; set; }

    [ColumnDescription("")]
    public string WMSCNName { get; set; }

    [ColumnDescription("")]
    public string CMSCNName { get; set; }

    [ColumnDescription("")]
    public string IfDeliveryNotice { get; set; }

    [ColumnDescription("")]
    public string IfSetShippingTemplate { get; set; }

    [ColumnDescription("")]
    public string IfOnlineDelivery { get; set; }

    [ColumnDescription("")]
    public string ExpressURL { get; set; }

    [ColumnDescription("")]
    public string FromCountryCode { get; set; }

    [ColumnDescription("")]
    public int PingTaiIDPak { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }
  }
}
