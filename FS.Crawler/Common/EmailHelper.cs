using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FS.Crawler.Common
{
    public class EmailHelper
    {
        private readonly static string sendEmail = ConfigurationSettings.AppSettings["SendEmail"].ToString();
        private readonly static string emailAuthCode = ConfigurationSettings.AppSettings["EmailAuthCode"].ToString();

        public static string SendEmail(string title,string mailAddress,string content)
        {
            MailAddress from = new MailAddress(sendEmail, "fandesc");
            MailMessage mail = new MailMessage();
            mail.Subject = title;//标题
            mail.To.Add(mailAddress);//收地址
            mail.Body = content;//内容
            mail.From = from;
            SmtpClient client = new SmtpClient();
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.qq.com";//邮箱SMtp地址QQ
            client.Credentials = new System.Net.NetworkCredential(sendEmail, emailAuthCode);
            try
            {
                client.Send(mail);//发送
                return "成功发送";
            }
            catch (Exception err)
            {
                return "发送失败" + err.Message.ToString();

            }
        }
    }
}
