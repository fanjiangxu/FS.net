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

namespace FS.net
{
    class Program
    {    
        static void Main(string[] args)
        {
            try
            {
                var data = "{\"SiteID\":11,\"UserName\":\"蓝智敏\",\"UserEmail\":null,\"SPUID\":12677942,\"Remark\":\"供应商缺货 \",\"SaleOffCategory\":1,\"SkuID\":[],\"Specification\":\"[颜色] =[粉色]@[尺寸]=[M]\"}";
                //  var a = JsonConvert.DeserializeObject<DownShelfItem>(data);
                System.Web.Script.Serialization.JavaScriptSerializer jss = new System.Web.Script.Serialization.JavaScriptSerializer();
                DownShelfItem item = jss.Deserialize<DownShelfItem>(data);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
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
