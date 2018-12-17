using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Lithograph
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string PhotoName { get; set; }

    [ColumnDescription("")]
    public string PhotoFullName { get; set; }

    [ColumnDescription("")]
    public int Size { get; set; }

    [ColumnDescription("")]
    public string Remark { get; set; }

    [ColumnDescription("")]
    public int UploadUserId { get; set; }

    [ColumnDescription("")]
    public DateTime AddDate { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int LithographTypeID { get; set; }

    [ColumnDescription("")]
    public string UserIP { get; set; }
  }
}
