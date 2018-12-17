using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PromoCodeMark
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int OrderID { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("优惠码标识 1 为SEO coupon 2 为 联盟 coupon")]
    public int Type { get; set; }

    [ColumnDescription(" 1 为标识 2 为 取消")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int AddUser { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }
  }
}
