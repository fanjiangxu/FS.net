using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class tempPackageWeight
  {

    [ColumnDescription("")]
    public int id { get; set; }

    [ColumnDescription("")]
    public decimal PackageWeight { get; set; }
  }
}
