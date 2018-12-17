using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Plateform_Ali_Shipping_Type
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string display_name { get; set; }

    [ColumnDescription("")]
    public string logistics_company { get; set; }

    [ColumnDescription("")]
    public int max_process_day { get; set; }

    [ColumnDescription("")]
    public int min_process_day { get; set; }

    [ColumnDescription("")]
    public int recommend_order { get; set; }

    [ColumnDescription("")]
    public string service_name { get; set; }

    [ColumnDescription("")]
    public string tracking_no_regex { get; set; }

    [ColumnDescription("")]
    public string WMSCNName { get; set; }
  }
}
