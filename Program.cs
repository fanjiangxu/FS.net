using Dapper;
using FS.DAL;
using FS.FileBackup;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FS.DAL.Model;
using System.Threading;
using FS.Framework;
using System.Net;
using System.Xml;
using System.Web;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Newtonsoft.Json;
using System.Net.Http;

namespace FS.net
{
    class Program
    {    
        static void Main(string[] args)
        {
            try
            {

                //WorkHelper.test();
                //var data = "{\"SiteID\":11,\"UserName\":\"蓝智敏\",\"UserEmail\":null,\"SPUID\":12677942,\"Remark\":\"供应商缺货 \",\"SaleOffCategory\":1,\"SkuID\":[],\"Specification\":\"[颜色] =[粉色]@[尺寸]=[M]\"}";
                ////  var a = JsonConvert.DeserializeObject<DownShelfItem>(data);
                //System.Web.Script.Serialization.JavaScriptSerializer jss = new System.Web.Script.Serialization.JavaScriptSerializer();
                //DownShelfItem item = jss.Deserialize<DownShelfItem>(data);



                AdyenReports();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
        public static void AdyenReports()
        {
            using (HttpClient client=new HttpClient())
            {
                try
                {
                    // var url = "https://ca-live.adyen.com/reports/download/Company/Tidepay/dispute_report_2018_11_21.csv";
                    //var responseText = client.GetStringAsync(url).Result;
                    //Console.WriteLine(responseText);

                    //using (SFTPHelper sftp = new SFTPHelper("ca-live.adyen.com", "chargeback", "Tidebuy2018",0))
                    //{
                    //    List<string> filelist = sftp.GetFileNameList("/reports/download/Tidepay/Tidepay/", "RFICHB*.csv");

                    //}

                    //var dict = new Dictionary<string, string>() { { "USER", "chargeback"},{ "PASS", "Tidebuy2018"} };
                    ////var result = HttpHelper1.CreatePostHttpResponse(url, dict, 10000,"",null);
                    //var url = "https://ca-live.adyen.com/reports/download/Company/Tidepay/dispute_report_2018_11_21.csv?username='report@Company.Tidepay'&password='4@n8VbFa(r%rkhgI6k5JMShnI'";
                    //var result = HttpHelper1.CreateGetHttpResponse(url, 10000, "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36", null);
                    //Console.WriteLine();


                    var url = "https://ca-live.adyen.com/reports/download/Company/Tidepay/dispute_report_2018_11_21.csv";
                    //string authUrl = url.Replace("http://", "");
                    //HttpRequest request = new HttpRequest("dispute_report_2018_11_21.csv",url,"");
                    //string userName = "report@Company.Tidepay";
                    //string password = "4@n8VbFa(r%rkhgI6k5JMShnI";
                    //string encoded = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes($"{userName}:{password}"));
                    //request.Headers.Add("Authorization", $"Basic {encoded}");
                    ////    var result= request

                    var response = HttpHelper1.CreatePostHttpResponse(url);
                    var resStream=response.GetResponseStream();
                    string content = "";
                    //using (StreamReader sr = new StreamReader(resStream))
                    //{
                    //    content = sr.ReadToEnd();
                    //}
                    DownFile(resStream,"dispute_report_2018_11_21.csv.");
                    Console.WriteLine(content);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        public static void DownFile(Stream str, string filename)
        {
            var localPath = System.AppDomain.CurrentDomain.BaseDirectory;
            localPath = Path.GetFullPath("../..");
            StreamReader reader = new StreamReader(str);
            byte[] mbyte = new byte[1000000];
            int allmybyte = (int)mbyte.Length;
            int startmbyte = 0;
            while (allmybyte > 0)
            {

                int m = str.Read(mbyte, startmbyte, allmybyte);
                if (m == 0)
                {
                    break;
                }
                startmbyte += m;
                allmybyte -= m;
            }
            reader.Dispose();
            str.Dispose();
            //string paths = localPath + System.IO.Path.GetFileName(uRLAddress);
            string path = localPath + filename;
            FileStream fstr = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            fstr.Write(mbyte, 0, startmbyte);
            fstr.Flush();
            fstr.Close();
        }


        //public void downLoad(String remoteFileName, String localFileName)
        //{
        //    HttpClient client = new HttpClient();
        //    GetMethod get = null;
        //    FileOutputStream output = null;

        //    try
        //    {
        //        get = new GetMethod(URL_STR);
        //        get.setRequestHeader("userName", userName);
        //        get.setRequestHeader("passwd", passwd);
        //        get.setRequestHeader("fileName", remoteFileName);

        //        int i = client.executeMethod(get);

        //        if (SUCCESS == i)
        //        {
        //            System.out.println("The response value of token:" + get.getResponseHeader("token"));

        //            File storeFile = new File(localFileName);
        //            output = new FileOutputStream(storeFile);

        //            // 得到网络资源的字节数组,并写入文件
        //            output.write(get.getResponseBody());
        //        }
        //        else
        //        {
        //            System.out.println("DownLoad file occurs exception, the error code is :" + i);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        e.printStackTrace();
        //    }
        //    finally
        //    {
        //        try
        //        {
        //            if (output != null)
        //            {
        //                output.close();
        //            }
        //        }
        //        catch (IOException e)
        //        {
        //            e.printStackTrace();
        //        }

        //        get.releaseConnection();
        //        client.getHttpConnectionManager().closeIdleConnections(0);
        //    }
        //}







        public class DownShelfItem
        {
            public DownShelfItem() { }

            private string orderID;
            public string OrderID
            {
                get { return orderID; }
                set { orderID = value; }
            }

            private string orderBillID;
            public string OrderBillID
            {
                get { return orderBillID; }
                set { orderBillID = value; }
            }

            private int siteID;
            public int SiteID
            {
                get { return siteID; }
                set { siteID = value; }
            }

            private string userName;
            public string UserName
            {
                get { return userName; }
                set { userName = value; }
            }

            private string userEmail;
            public string UserEmail
            {
                get { return userEmail; }
                set { userEmail = value; }
            }
            /// <summary>
            /// 产品id  productid
            /// </summary>
            /// 
            private int sPUID;
            public int SPUID
            {
                get { return sPUID; }
                set { sPUID = value; }
            }

            private string remark;
            public string Remark
            {
                get { return remark; }
                set { remark = value; }
            }

            private string saleOffCategory;
            public string SaleOffCategory
            {
                get { return saleOffCategory; }
                set { saleOffCategory = value; }
            }


            private List<int> skuID;
            public List<int> SkuID
            {
                get { return skuID; }
                set { skuID = value; }
            }

            private string specification;
            public string Specification
            {
                get { return specification; }
                set { specification = value; }
            }

        }

        public class OrderBillModel
        {
            private string orderID;
            public string OrderID
            {
                get { return orderID; }
                set { orderID = value; }
            }

            private string orderBillID;
            public string OrderBillID
            {
                get { return orderBillID; }
                set { orderBillID = value; }
            }

            private int siteID;
            public int SiteID
            {
                get { return siteID; }
                set { siteID = value; }
            }
        }
    }
}
