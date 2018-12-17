using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class SendFriendEmail
  {

    [ColumnDescription("")]
    public int Id { get; set; }

    [ColumnDescription("")]
    public string ProductId { get; set; }

    [ColumnDescription("")]
    public string SendFriendEmail1 { get; set; }

    [ColumnDescription("")]
    public string UserEmail { get; set; }

    [ColumnDescription("")]
    public string UserName { get; set; }

    [ColumnDescription("")]
    public string FriendName { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public string UserMessage { get; set; }
  }
}
