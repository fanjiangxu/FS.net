using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class NewCalendar
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public int AdminID { get; set; }

    [ColumnDescription("")]
    public string LogTitle { get; set; }

    [ColumnDescription("")]
    public string LogText { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public DateTime StartTime { get; set; }

    [ColumnDescription("")]
    public DateTime EndTime { get; set; }

    [ColumnDescription("")]
    public int ContinueTime { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public DateTime UpdateTime { get; set; }

    [ColumnDescription("")]
    public int CalendarLevel { get; set; }
  }
}
