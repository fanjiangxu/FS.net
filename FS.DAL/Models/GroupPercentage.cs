using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class GroupPercentage
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public int CommentsGroup { get; set; }

    [ColumnDescription("")]
    public int CommentGroup { get; set; }

    [ColumnDescription("")]
    public int Percentage { get; set; }
  }
}
