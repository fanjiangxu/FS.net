using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Country2
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string CountryName { get; set; }

    [ColumnDescription("")]
    public string CNName { get; set; }

    [ColumnDescription("")]
    public int ZoneEMS { get; set; }

    [ColumnDescription("")]
    public int ZoneDHL { get; set; }

    [ColumnDescription("")]
    public int ZoneTNT { get; set; }

    [ColumnDescription("")]
    public int ZoneUPS { get; set; }

    [ColumnDescription("")]
    public int ZoneFedex { get; set; }

    [ColumnDescription("")]
    public int ZoneAirSmall { get; set; }

    [ColumnDescription("")]
    public string CountryCode { get; set; }

    [ColumnDescription("")]
    public int ZoneEMS2 { get; set; }

    [ColumnDescription("")]
    public string CountryName_Fr { get; set; }

    [ColumnDescription("")]
    public string CounTryName_Es { get; set; }

    [ColumnDescription("")]
    public string CountryCoding { get; set; }

    [ColumnDescription("")]
    public string CounTryName_Jp { get; set; }

    [ColumnDescription("")]
    public string CountryShort { get; set; }

    [ColumnDescription("")]
    public string Abbreviation { get; set; }

    [ColumnDescription("")]
    public string PhoneCode { get; set; }

    [ColumnDescription("")]
    public string AreaCode { get; set; }

    [ColumnDescription("")]
    public string ZoneBiYouSmall { get; set; }

    [ColumnDescription("")]
    public string ZoneDHLSmall { get; set; }
  }
}
