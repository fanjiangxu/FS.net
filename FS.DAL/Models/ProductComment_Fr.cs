using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ProductComment_Fr
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int UserID { get; set; }

    [ColumnDescription("")]
    public int ProductID { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public string Content { get; set; }

    [ColumnDescription("")]
    public int Level { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string UserName { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public string Reply { get; set; }

    [ColumnDescription("")]
    public string Title { get; set; }

    [ColumnDescription("")]
    public int replayUserID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int BillID { get; set; }

    [ColumnDescription("")]
    public DateTime CommentDate { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public DateTime ReplyDate { get; set; }

    [ColumnDescription("")]
    public string images { get; set; }

    [ColumnDescription("")]
    public int ShipSpeed { get; set; }

    [ColumnDescription("")]
    public int CustomerService { get; set; }

    [ColumnDescription("")]
    public int Quality { get; set; }

    [ColumnDescription("")]
    public int Support { get; set; }

    [ColumnDescription("")]
    public int Against { get; set; }

    [ColumnDescription("")]
    public int CommentType { get; set; }

    [ColumnDescription("")]
    public int ConsultingType { get; set; }

    [ColumnDescription("")]
    public int GoodISbad { get; set; }

    [ColumnDescription("")]
    public string ParentIDs { get; set; }

    [ColumnDescription("")]
    public int IsImport { get; set; }

    [ColumnDescription("")]
    public int IsComplaint { get; set; }

    [ColumnDescription("")]
    public int LanguageID { get; set; }

    [ColumnDescription("")]
    public string Style { get; set; }

    [ColumnDescription("")]
    public string Age { get; set; }
  }
}
