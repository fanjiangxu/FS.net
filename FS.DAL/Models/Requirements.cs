using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Requirements
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public string txtName { get; set; }

    [ColumnDescription("")]
    public int AdminId { get; set; }

    [ColumnDescription("")]
    public string txtWordName { get; set; }

    [ColumnDescription("")]
    public DateTime txtWordTime { get; set; }

    [ColumnDescription("")]
    public string txtWordCompetentName { get; set; }

    [ColumnDescription("")]
    public string sleWord { get; set; }

    [ColumnDescription("")]
    public string txtWord { get; set; }

    [ColumnDescription("")]
    public string txtResult { get; set; }

    [ColumnDescription("")]
    public string txtTDCManagerName { get; set; }

    [ColumnDescription("")]
    public string txtTDCExecutorName { get; set; }

    [ColumnDescription("")]
    public string txtWordDemand { get; set; }

    [ColumnDescription("")]
    public DateTime txtSchedulingTime { get; set; }

    [ColumnDescription("")]
    public DateTime txtSchedulingEndTime { get; set; }

    [ColumnDescription("")]
    public DateTime txtCompletionTime { get; set; }

    [ColumnDescription("")]
    public string txtTestManagerName { get; set; }

    [ColumnDescription("")]
    public string txtTestExecutorName { get; set; }

    [ColumnDescription("")]
    public DateTime txtTestSchedulingTime { get; set; }

    [ColumnDescription("")]
    public DateTime txtTestSchedulingEndTime { get; set; }

    [ColumnDescription("")]
    public string txtTextResult { get; set; }

    [ColumnDescription("")]
    public string txtFeedbackName { get; set; }

    [ColumnDescription("")]
    public DateTime txtFeedbackTime { get; set; }

    [ColumnDescription("")]
    public string txtFeedbackResult { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
