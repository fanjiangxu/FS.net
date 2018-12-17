using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class PaymentType_Info
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int SiteId { get; set; }

    [ColumnDescription("名称[不是前台用的]")]
    public string Name { get; set; }

    [ColumnDescription("标签HTML")]
    public string TabHtml { get; set; }

    [ColumnDescription("标签对应内容HTML")]
    public string TabContentHtml { get; set; }

    [ColumnDescription("TB_PayMethodAndPaymentCompanyMapping表ID，即PayType值")]
    public int PayMethodPaymentMappingID { get; set; }

    [ColumnDescription("状态 1正常,0不使用")]
    public int Status { get; set; }

    [ColumnDescription("添加时间")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("添加人邮箱")]
    public string AddUserEmail { get; set; }

    [ColumnDescription("")]
    public string ApiGetRedirectUrl { get; set; }

    [ColumnDescription("")]
    public decimal ShowMinPrice { get; set; }

    [ColumnDescription("")]
    public decimal ShowMaxPrice { get; set; }

    [ColumnDescription("")]
    public int Platform { get; set; }

    [ColumnDescription("")]
    public int OldID { get; set; }
  }
}
