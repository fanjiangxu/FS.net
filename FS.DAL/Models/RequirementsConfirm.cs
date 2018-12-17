using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class RequirementsConfirm
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public DateTime ConfirmTime { get; set; }

    [ColumnDescription("")]
    public string ProjectName { get; set; }

    [ColumnDescription("")]
    public string DemandWardName { get; set; }

    [ColumnDescription("")]
    public string Department { get; set; }

    [ColumnDescription("")]
    public DateTime DemandWardTime { get; set; }

    [ColumnDescription("")]
    public string DemandWardtype { get; set; }

    [ColumnDescription("")]
    public string Level { get; set; }

    [ColumnDescription("")]
    public string ProductsName { get; set; }

    [ColumnDescription("")]
    public string DemandReason { get; set; }

    [ColumnDescription("")]
    public string AnalysisPoints { get; set; }

    [ColumnDescription("")]
    public string TheProduct { get; set; }

    [ColumnDescription("")]
    public string DemandPeople { get; set; }

    [ColumnDescription("")]
    public string DepaTment { get; set; }

    [ColumnDescription("")]
    public string Scheme { get; set; }

    [ColumnDescription("")]
    public string Cycle { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int AdminId { get; set; }
  }
}
