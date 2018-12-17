using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PaymentType_Country_Mapping
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("TB_PaymentType_Info   支付类型表ID")]
    public int PaymentTypeId { get; set; }

    [ColumnDescription("国家ID")]
    public int CountryId { get; set; }

    [ColumnDescription("排序值")]
    public int Sort { get; set; }

    [ColumnDescription("状态 1正常,0不使用")]
    public int Status { get; set; }

    [ColumnDescription("支付方式币种信息")]
    public string CountryCurrencyJSON { get; set; }

    [ColumnDescription("添加时间")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("添加人邮箱")]
    public string AddUserEmail { get; set; }

    [ColumnDescription("是否是测试数据     ")]
    public int IsTest { get; set; }

    [ColumnDescription("")]
    public int Platform { get; set; }

    [ColumnDescription("")]
    public string LogText { get; set; }
  }
}
