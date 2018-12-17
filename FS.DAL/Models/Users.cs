using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FS.Framework;
namespace FS.DAL.Models
{
  public class Users
  {

    [ColumnDescription("")]
    public int ID { get; set; }

    [ColumnDescription("")]
    public string Password { get; set; }

    [ColumnDescription("")]
    public string Email { get; set; }

    [ColumnDescription("")]
    public DateTime RegDate { get; set; }

    [ColumnDescription("")]
    public string RegIP { get; set; }

    [ColumnDescription("")]
    public string LastLoginIP { get; set; }

    [ColumnDescription("")]
    public DateTime LastLoginDate { get; set; }

    [ColumnDescription("改变字段原有意义  此字段目前标示用户注册来源  0:pc  1:m, 3:app TB手机站已使用")]
    public int Points { get; set; }

    [ColumnDescription("")]
    public int State { get; set; }

    [ColumnDescription("")]
    public int UserType { get; set; }

    [ColumnDescription("")]
    public int UserLevel { get; set; }

    [ColumnDescription("")]
    public int BlackType { get; set; }

    [ColumnDescription("")]
    public int SiteID { get; set; }

    [ColumnDescription("")]
    public int LanguageID { get; set; }

    [ColumnDescription("")]
    public int LoginCount { get; set; }

    [ColumnDescription("")]
    public int BigClient { get; set; }

    [ColumnDescription("")]
    public string Gender { get; set; }

    [ColumnDescription("")]
    public string RegBirthdayMonth { get; set; }

    [ColumnDescription("")]
    public string Image { get; set; }

    [ColumnDescription("")]
    public int Agreement { get; set; }

    [ColumnDescription("")]
    public DateTime AgreementDate { get; set; }

    [ColumnDescription("")]
    public int IsSub { get; set; }

    [ColumnDescription("")]
    public int EmailValidateState { get; set; }

    [ColumnDescription("")]
    public string InviteCode { get; set; }
  }
}
