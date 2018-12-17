using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Site
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string LogoName { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public string UserName { get; set; }

    [ColumnDescription("")]
    public string Password { get; set; }

    [ColumnDescription("")]
    public string ImgSiteUrl { get; set; }

    [ColumnDescription("状态：1-启用；0:禁用")]
    public string State { get; set; }

    [ColumnDescription("")]
    public int SiteID223 { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }
  }
}
