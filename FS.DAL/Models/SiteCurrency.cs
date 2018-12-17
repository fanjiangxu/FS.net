using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SiteCurrency
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public string CurrencyName { get; set; }

    [ColumnDescription("")]
    public decimal Rate { get; set; }

    [ColumnDescription("")]
    public string CurrencySign { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("")]
    public decimal TheCurrentRate { get; set; }

    [ColumnDescription("")]
    public decimal TheCurrentPoints { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public int isConversation { get; set; }

    [ColumnDescription("")]
    public int isemploy { get; set; }
  }
}
