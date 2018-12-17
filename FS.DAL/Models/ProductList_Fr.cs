using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductList_Fr
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public string Summary { get; set; }

    [ColumnDescription("")]
    public string Images { get; set; }

    [ColumnDescription("")]
    public string CategoryIDs { get; set; }

    [ColumnDescription("")]
    public string ParentIDs { get; set; }

    [ColumnDescription("")]
    public int Unit { get; set; }

    [ColumnDescription("")]
    public int MinNum { get; set; }

    [ColumnDescription("")]
    public int FakeLevel { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int Shipping { get; set; }

    [ColumnDescription("")]
    public int Views { get; set; }

    [ColumnDescription("")]
    public int SaleCount { get; set; }

    [ColumnDescription("")]
    public decimal Original { get; set; }

    [ColumnDescription("")]
    public int Review { get; set; }

    [ColumnDescription("")]
    public int ReviewPoint { get; set; }

    [ColumnDescription("")]
    public decimal ProductWeight { get; set; }

    [ColumnDescription("")]
    public decimal Price { get; set; }

    [ColumnDescription("")]
    public decimal MarketPrice { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int Size { get; set; }

    [ColumnDescription("")]
    public int Sort { get; set; }

    [ColumnDescription("")]
    public DateTime EndDate { get; set; }

    [ColumnDescription("")]
    public int oldID { get; set; }

    [ColumnDescription("")]
    public decimal Discount { get; set; }

    [ColumnDescription("")]
    public int IsNew { get; set; }

    [ColumnDescription("")]
    public DateTime OutDate { get; set; }

    [ColumnDescription("")]
    public DateTime IsNewDate { get; set; }

    [ColumnDescription("")]
    public string Ratio { get; set; }

    [ColumnDescription("")]
    public int StudioID { get; set; }

    [ColumnDescription("")]
    public string TitleUrl { get; set; }

    [ColumnDescription("")]
    public int IsHot { get; set; }

    [ColumnDescription("")]
    public int Is24H { get; set; }

    [ColumnDescription("")]
    public int PmsCategoryID { get; set; }

    [ColumnDescription("")]
    public int SPUID { get; set; }
  }
}
