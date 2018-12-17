using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class ChatRoom
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string UserFrom { get; set; }

    [ColumnDescription("")]
    public string UserTo { get; set; }

    [ColumnDescription("")]
    public string UserSend { get; set; }

    [ColumnDescription("")]
    public string UserNameSend { get; set; }

    [ColumnDescription("")]
    public string Content { get; set; }

    [ColumnDescription("")]
    public DateTime AddTime { get; set; }

    [ColumnDescription("")]
    public string IP { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }
  }
}
