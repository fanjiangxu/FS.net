using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Project
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Name { get; set; }

    [ColumnDescription("")]
    public string CreateUser { get; set; }

    [ColumnDescription("")]
    public DateTime CreateDate { get; set; }

    [ColumnDescription("")]
    public string Manager { get; set; }

    [ColumnDescription("")]
    public string Description { get; set; }

    [ColumnDescription("")]
    public DateTime DateStart { get; set; }

    [ColumnDescription("")]
    public DateTime DateEnd { get; set; }

    [ColumnDescription("")]
    public string JoinUser { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public string Appendix { get; set; }
  }
}
