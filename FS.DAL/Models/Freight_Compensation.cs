using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Freight_Compensation
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public string Phone { get; set; }

    [ColumnDescription("")]
    public int OrderId { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("快递公司")]
    public string ExpressCompany { get; set; }

    [ColumnDescription("快递单号")]
    public string ExpressNO { get; set; }

    [ColumnDescription("币种名称")]
    public string CurrencyName { get; set; }

    [ColumnDescription("快递费用多币种金额")]
    public decimal CurrencyPrice { get; set; }

    [ColumnDescription("退货原因")]
    public string Reason { get; set; }

    [ColumnDescription("运费补偿方式  1：优惠码     2：星巴克咖啡券")]
    public int CompensateMethod { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("1:未处理     2：处理中    3：已处理")]
    public int Status { get; set; }

    [ColumnDescription("处理人")]
    public int HanldUser { get; set; }

    [ColumnDescription("处理时间")]
    public DateTime HanldTime { get; set; }
  }
}
