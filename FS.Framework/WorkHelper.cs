using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace FS.Framework
{
    public  static class WorkHelper
    {
        public static DataTable dt;
        public static int count = 1;
        //  public static DataTable newdt;
        public static List<ManualResetEvent> manualEvents = new List<ManualResetEvent>();
        public static void test()
        {
            //string url = "http://www.cofool.com/Home/User/tradeItem.html";
            //string type = "entrust";
            //string gid = "16703";
            //string uid = "16703X4952904";
            //string web_id = "110";
            //string all_balance = "1101157.836";
            //string archive = "0";
            //string result = program.HttpPostWebService(url, type, gid, uid, web_id, all_balance, archive);

            //string OrderID = "676878";
            //string OrderBillID = "1925673";
            //string ReturnExpressNo = "3131321";
            //string ReturnExpressType = "E邮宝";
            //string DeliveryExpressNo = "22144550055";
            //string DeliveryExpressType = "联邦特快";
            //string UserInfo = "lxy123";
            //string Country = "英国";
            //string SendAddress = "石格特120号";
            //int ReceiveWarehouseID = 52;
            //int ReturnCount = 1;
            //int SiteID = 27;
            //int ApplyState = 1;
            //string ApplyTime = "2018-08-16";
            //string ApplyUserName = "lixunyan";
            //string Remark = "cesg";
            //string param = HttpUtility.UrlEncode("OrderID") + "=" + HttpUtility.UrlEncode(OrderID)
            //+ "&" + HttpUtility.UrlEncode("gid") + "=" + HttpUtility.UrlEncode(gid)
            // + "&" + HttpUtility.UrlEncode("uid") + "=" + HttpUtility.UrlEncode(uid)
            //  + "&" + HttpUtility.UrlEncode("web_id") + "=" + HttpUtility.UrlEncode(web_id)
            //   + "&" + HttpUtility.UrlEncode("web_id") + "=" + HttpUtility.UrlEncode(web_id)
            //    + "&" + HttpUtility.UrlEncode("all_balance") + "=" + HttpUtility.UrlEncode(all_balance)
            //      + "&" + HttpUtility.UrlEncode("archive") + "=" + HttpUtility.UrlEncode(archive);
            //  string url = " http://test.api.scm.tidebuy.net/api/Order/OrderApplyReturn";
            //              string param = "{  \"OrderID\": \"611662\",  \"OrderBillID\": \"932571\",  \"ReturnExpressNo\": \"3131321\",  \"ReturnExpressType\": \"E邮宝\","
            //+ "\"DeliveryExpressNo\": \"22144550055\",  \"DeliveryExpressType\": \"联邦特快\",  \"UserInfo\": \"lxy123\",  \"Country\": \"英国\",  \"SendAddress\": \"石格特120号\","
            //+ "\"ReceiveWarehouseID\": 52,  \"ReturnCount\": 1,  \"SiteID\": 19,  \"ApplyState\": 1,  \"ApplyTime\": \"2018-08-16\",  \"ApplyUserName\": \"lixunyan\","
            //+ "\"Remark\": \"cesg-test\"}";
            //   string param = "{\"OrderID\":\"676878\",\"OrderBillID\":\"1925673\",\"SiteID\":27,\"ReturnCount\":1,\"ApplyTime\":\"2018-08-16T00:00:00\",\"ApplyUserName\":\"lixunyan\",\"Remark\":\"cesg\",\"ProcessState\":0,\"ApplyState\":1,\"ReturnExpressNo\":\"3131321\",\"ReturnExpressType\":\"E邮宝\",\"DeliveryExpressNo\":\"22144550055\",\"DeliveryExpressType\":\"联邦特快\",\"UserInfo\":\"lxy123\",\"Country\":\"英国\",\"SendAddress\":\"石格特120号\",\"ReceiveWarehouseID\":52,\"CreateUserName\":\"lixunyan\",\"CreateTime\":\"2018-08-16T17:46:54.903808+08:00\",\"UpdateUserName\":null,\"UpdateTime\":\"0001-01-01T00:00:00\",\"ID\":0}";
            //string result = program.HttpPostWebService(url, param);
            // string result = Post(url,param);
            // string result =RemotePostHelper.PostMoths(url, param);
            //string url = " http://cms.tidebuy2.cn/api/webapi.aspx?type=insertuserrefundapply";
            //string param = "{\"SiteID\":\"19\",\"OrderID\":\"611662\",\"OrderBillID\":\"932568\",\"Type\":2,\"ReturnExpressNo\":\"100010\",\"ReturnExpressType\":\"TNT\",\"RefundReason\":\"testRefundReason\""
            //    + ",\"DetailContent\":\"testapi\",\"Images\":\"https://ss.beddinginn.com/images/product/c/106068/13381/13381044_7.jpeg\",\"Mobile\":\"18201520114\",\"UserApplyRefundMoney\":19.99,\"Price\":\"19.99\",\"ShippingPrice\":\"1.00\",\"DiscountPrice\":\"2.00\",\"CurrencyName\":\"USD\","
            //    + "\"RefundProductCount\":1,\"NewInfoID\":10012,\"Remark\":\"testRemark\",\"ApplyState\":1}";
            //string result = RemotePostHelper.Post(url, param);
            //string url = "http://api.scm.tidebuy.net/Help/Api/GET-api-StockWareHouse-Get";
            //string result = RemotePostHelper.PostMoths(url,"");
            ExeclToRepot();
            Console.WriteLine();
        }


        public static void ExeclToRepot()
        {
            //供应商产品数据
            GetProductSource();

            #region 导出spu基础优化数据
            //导出spu基础优化数据
            //dt = GetSource();
            //count = dt.Rows.Count;
            //SaveExecl(0);
            //多线程导出spu基础优化数据
            //for (int i = 0; i < 20; i++)     //将任务加到线程当中
            //{
            //    if (i == 2||i==14)
            //    {
            //        ManualResetEvent mre = new ManualResetEvent(false);
            //        manualEvents.Add(mre);
            //        ThreadPool.QueueUserWorkItem(new WaitCallback(SmallThread), i);
            //        if (i == 0)
            //        {
            //            ThreadPool.QueueUserWorkItem(new WaitCallback(SaveExecl), 0);
            //        }
            //    }
            //}
            //WaitHandle.WaitAll(manualEvents.ToArray());
            #endregion
        }

        /// <summary>
        /// 产品首图
        /// </summary>
        /// <param name="images"></param>
        /// <returns></returns>
        public static string GetOneProductImg(string images)
        {
            if (images == "")
            {
                return "";
            }
            string[] imgs = images.Split(',');
            string img = imgs[0];
            if (img == "")
            {
                img = imgs[1];
            }
            if (img.IndexOf("http://") > -1)
            {
                return img;
            }
            try
            {
                int id = int.Parse(img.Substring(0, img.IndexOf("_")));
                img = "https://ss.beddinginn.com/images/product/" + id / 1000000 + "/" + id / 1000 + "/" + img;
            }
            catch { }
            return img;
        }
        /// <summary>
        /// 供应商产品
        /// </summary>
        /// <returns></returns>
        private static void GetProductSource()
        {
            var sql = @"select p.ID '产品ID',p.SPUID,pr.ProductNo '供应商编号',p.Images '产品首图（大图/原图）访问链接',(case when p.Stock>0 then '有' else '无' end) '是否有货' from TB_Product p with(nolock) 
left join TB_ProductRelationShip pr with(nolock) on p.SiteID=pr.SiteID and p.ID=pr.PID
where p.SiteID=19 and (p.State=2 or p.State=1) and (pr.ProductNo like '%NTJF%' or pr.ProductNo like '%QXP%' or pr.ProductNo like '%NTGC%' or pr.ProductNo like '%HZ-DG%' or pr.ProductNo like '%TT-LX%' or pr.ProductNo like '%YPLT%')";
            var dt = Framework.SqlDbHelper.ExecuteDataTable(sql);

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var images = dt.Rows[i]["产品首图（大图/原图）访问链接"].ToString();
                images = GetOneProductImg(images);
                dt.Rows[i]["产品首图（大图/原图）访问链接"] = images;
            }
            ExeclHelper execl = new ExeclHelper();
            execl.DataTabletoExcel(dt, "D:\\供应商HZ-DG在售产品导表.xlsx");
            Console.WriteLine("供应商HZ-DG在售产品导表");
        }
        /// <summary>
        /// 必选区为空的产品
        /// </summary>
        private static void GetProductValIsNull()
        {
            var sql = @"select p11.ID,p11.SPUID,p11.SiteID from TB_Product p11 with(nolock)
left join
View_OptionContent v WITH(NOLOCK) 
on v.SiteID=p11.SiteID and v.CurrentID=p11.ID and v.Type=2 and v.SiteID=9 
WHERE p11.SiteID=9 and v.ID is null and (p11.State=1 or p11.State=0)
group by p11.ID,p11.SPUID,p11.SiteID";
            var dt = SqlDbHelper.ExecuteDataTable(sql);
            ExeclHelper execl = new ExeclHelper();
            execl.DataTabletoExcel(dt, "D:\\必选区为空产品SiteID_9.xlsx");
            Console.WriteLine("必选区为空产品SiteID_9");
        }


        public static void SaveExecl(object filename)
        {
            //  dt = GetSource();
            DataTable newdt = new DataTable();
            newdt.Columns.Add("品类ID", System.Type.GetType("System.String"));
            newdt.Columns.Add("SPUID", System.Type.GetType("System.String"));
            newdt.Columns.Add("SiteID", System.Type.GetType("System.String"));
            newdt.Columns.Add("Color", System.Type.GetType("System.String"));
            newdt.Columns.Add("Size", System.Type.GetType("System.String"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var remark2 = dt.Rows[i]["Remark2"] != DBNull.Value ? Convert.ToString(dt.Rows[i]["Remark2"]) : "";
                string color = "";
                string size = "";
                int currencyInt = 1;
                if (!string.IsNullOrEmpty(remark2))
                {
                    remark2 = remark2.Replace("@@", "@");
                    remark2 = remark2.Trim('@');
                    remark2 = remark2.Replace("Material - Synthetic Wigs-Machine Weft", "");
                    if (remark2.Contains("@~"))
                    {
                        remark2 = remark2.Substring(0, remark2.IndexOf("@~"));
                    }
                    string temp_remark2 = ReversionShopCartRemark(remark2);
                    System.Collections.Generic.List<string> listcm = new System.Collections.Generic.List<string>();
                    string[] remark2s = remark2.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] tempRemark2s = temp_remark2.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                    if (remark2s.Length != tempRemark2s.Length)
                    {
                        temp_remark2 = remark2;
                    }
                    if (temp_remark2.Length > 0)
                    {
                        string itemString = "";
                        int itemint = 0;
                        string remark3 = temp_remark2.Replace("Material - Synthetic Wigs-Machine Weft", "");
                        string[] strs = remark3.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string item in strs)
                        {
                            itemString += item;
                            if (item.Contains("~") && !item.Contains("-"))
                            {
                                string[] customAttr = item.Split(new char[] { '~' }, StringSplitOptions.RemoveEmptyEntries);
                                if (customAttr.Length <= 0) continue;
                                foreach (string customItem in customAttr)
                                {
                                    string[] custom = customItem.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                                    if (custom.Length < 2) continue;
                                    string key = custom[0];
                                    string values = custom[1];
                                    if (key.ToLower().Contains("color") && !string.IsNullOrEmpty(values))
                                    {
                                        values = TranslateColor(values.Trim(), currencyInt);
                                        color = values;
                                    }
                                    itemint++;
                                }
                            }
                            else
                            {
                                string[] attr = item.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                                if (attr.Length < 2) attr = item.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                                if (attr.Length < 2) attr = item.Split(new char[] { '：' }, StringSplitOptions.RemoveEmptyEntries);
                                if (attr.Length < 2 && attr.Length == 1)
                                {
                                }
                                else
                                {
                                    string key = attr[0];
                                    string values = item.Substring(attr[0].Length + 1, item.Length - attr[0].Length - 1);
                                    if (key.ToLower().Contains("size") && !string.IsNullOrEmpty(values))
                                    {
                                        size = values;
                                    }
                                    if (key.ToLower().Contains("color") && !string.IsNullOrEmpty(values))
                                    {
                                        color = values;
                                    }
                                }
                                itemint++;
                            }
                        }
                    }
                }
                DataRow dr = newdt.NewRow();
                dr["品类ID"] = dt.Rows[i]["品类ID"] != DBNull.Value ? dt.Rows[i]["品类ID"].ToString() : "";
                dr["SPUID"] = dt.Rows[i]["SPUID"] != DBNull.Value ? dt.Rows[i]["SPUID"].ToString() : "";
                dr["SiteID"] = dt.Rows[i]["SiteID"] != DBNull.Value ? dt.Rows[i]["SiteID"].ToString() : "";
                dr["Color"] = color;
                dr["Size"] = size;
                newdt.Rows.Add(dr);
                if (i % 1000 == 0)
                {
                    Console.WriteLine("20w数据已完成：" + (i * 100 / Convert.ToDecimal(dt.Rows.Count)).ToString("0.00") + "%");
                }

            }
            Console.WriteLine("20w数据已完成,开始导出Execl文件");
            ExeclHelper execl = new ExeclHelper();
            execl.DataTabletoExcel(newdt, "D:\\SKU优化基础数据_20w.xlsx");
            Console.WriteLine("导出Execl完成_20w");
        }



        private static void DuoXiancheng()
        {
            dt = GetSource();
            //newdt = new DataTable();
            //newdt.Columns.Add("品类ID", System.Type.GetType("System.String"));
            //newdt.Columns.Add("SPUID", System.Type.GetType("System.String"));
            //newdt.Columns.Add("SiteID", System.Type.GetType("System.String"));
            //newdt.Columns.Add("Color", System.Type.GetType("System.String"));
            //newdt.Columns.Add("Size", System.Type.GetType("System.String"));
            for (int i = 0; i < 20; i++)     //将任务加到线程当中
            {
                ManualResetEvent mre = new ManualResetEvent(false);
                manualEvents.Add(mre);
                ThreadPool.QueueUserWorkItem(new WaitCallback(SmallThread), i);
            }
            WaitHandle.WaitAll(manualEvents.ToArray());
            // var t = newdt;
        }

        static void SmallThread(object filename)
        {
            Console.WriteLine(filename + "线程开始,ID：" + Thread.CurrentThread.ManagedThreadId);
            GetData(Convert.ToInt32(filename));
            Console.WriteLine("线程结束");
        }

        private static DataTable GetSource()
        {
            var sql = @"select p.PmsCategoryID '品类ID',p.SPUID,p.SiteID,bill.Remark2 from TB_OrderBill bill WITH(NOLOCK) 
inner join TB_Order ord WITH(NOLOCK) on ord.SiteID=bill.SiteID and ord.ID=bill.OrderID
inner join TB_Product p WITH(NOLOCK) on p.SiteID=bill.SiteID and p.ID=bill.ProductID
INNER JOIN dbo.TB_Users uses WITH(NOLOCK) ON uses.SiteID=ord.SiteID AND uses.ID=ord.UserID 
where CHARINDEX('tidebuy',[uses].[Email],0)=0 and bill.State>1 and bill.State<>20 and bill.State<>22 AND bill.SiteID in (0,1,8,11) and ord.PayTime>'2017-12-31' and ord.PayTime <'2018/8/1'  and p.PmsCategoryID in (141,142,143)
group by p.PmsCategoryID,p.SPUID,p.SiteID,bill.Remark2";
            var dt = SqlDbHelper.ExecuteDataTable(sql);
            return dt;
        }
        public static void GetData(int index)
        {
            DataTable newdt = new DataTable();
            newdt.Columns.Add("品类ID", System.Type.GetType("System.String"));
            newdt.Columns.Add("SPUID", System.Type.GetType("System.String"));
            newdt.Columns.Add("SiteID", System.Type.GetType("System.String"));
            newdt.Columns.Add("Color", System.Type.GetType("System.String"));
            newdt.Columns.Add("Size", System.Type.GetType("System.String"));

            int endindex = (index + 1) * (count / 20);
            int startindex = index * (count / 20);
            if (index == 19)
            {
                endindex = dt.Rows.Count;
            }
            for (int i = startindex; i < endindex; i++)
            {
                var remark2 = dt.Rows[i]["Remark2"] != DBNull.Value ? Convert.ToString(dt.Rows[i]["Remark2"]) : "";
                string color = "";
                string size = "";
                int currencyInt = 1;
                if (!string.IsNullOrEmpty(remark2))
                {
                    remark2 = remark2.Replace("@@", "@");
                    remark2 = remark2.Trim('@');
                    remark2 = remark2.Replace("Material - Synthetic Wigs-Machine Weft", "");
                    if (remark2.Contains("@~"))
                    {
                        remark2 = remark2.Substring(0, remark2.IndexOf("@~"));
                    }
                    string temp_remark2 = ReversionShopCartRemark(remark2);
                    System.Collections.Generic.List<string> listcm = new System.Collections.Generic.List<string>();
                    string[] remark2s = remark2.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] tempRemark2s = temp_remark2.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                    if (remark2s.Length != tempRemark2s.Length)
                    {
                        temp_remark2 = remark2;
                    }
                    if (temp_remark2.Length > 0)
                    {
                        string itemString = "";
                        int itemint = 0;
                        string remark3 = temp_remark2.Replace("Material - Synthetic Wigs-Machine Weft", "");
                        string[] strs = remark3.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string item in strs)
                        {
                            itemString += item;
                            if (item.Contains("~") && !item.Contains("-"))
                            {
                                string[] customAttr = item.Split(new char[] { '~' }, StringSplitOptions.RemoveEmptyEntries);
                                if (customAttr.Length <= 0) continue;
                                foreach (string customItem in customAttr)
                                {
                                    string[] custom = customItem.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                                    if (custom.Length < 2) continue;
                                    string key = custom[0];
                                    string values = custom[1];
                                    if (key.ToLower().Contains("color") && !string.IsNullOrEmpty(values))
                                    {
                                        values = TranslateColor(values.Trim(), currencyInt);
                                        color = values;
                                    }
                                    itemint++;
                                }
                            }
                            else
                            {
                                string[] attr = item.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                                if (attr.Length < 2) attr = item.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                                if (attr.Length < 2) attr = item.Split(new char[] { '：' }, StringSplitOptions.RemoveEmptyEntries);
                                if (attr.Length < 2 && attr.Length == 1)
                                {
                                }
                                else
                                {
                                    string key = attr[0];
                                    string values = item.Substring(attr[0].Length + 1, item.Length - attr[0].Length - 1);
                                    if (key.ToLower().Contains("size") && !string.IsNullOrEmpty(values))
                                    {
                                        size = values;
                                    }
                                    if (key.ToLower().Contains("color") && !string.IsNullOrEmpty(values))
                                    {
                                        color = values;
                                    }
                                }
                                itemint++;
                            }
                        }
                    }
                }
                DataRow dr = newdt.NewRow();
                dr["品类ID"] = dt.Rows[i]["品类ID"] != DBNull.Value ? dt.Rows[i]["品类ID"].ToString() : "";
                dr["SPUID"] = dt.Rows[i]["SPUID"] != DBNull.Value ? dt.Rows[i]["SPUID"].ToString() : "";
                dr["SiteID"] = dt.Rows[i]["SiteID"] != DBNull.Value ? dt.Rows[i]["SiteID"].ToString() : "";
                dr["Color"] = color;
                dr["Size"] = size;
                newdt.Rows.Add(dr);
                if (i % 1000 == 0)
                {
                    Console.WriteLine("线程" + index + "_数据已完成：" + ((i - startindex) * 100 / Convert.ToDouble(endindex - startindex)).ToString("0.00") + "%");
                }
            }
            Console.WriteLine("线程" + index + "_数据已完成,开始导出Execl文件");
            ExeclHelper execl = new ExeclHelper();
            execl.DataTabletoExcel(newdt, "D:\\SKU优化基础数据_" + index + ".xlsx");
            Console.WriteLine("导出Execl完成:" + index);
        }
        public static string ReversionShopCartRemark(string inputRemark)
        {
            string reStr = string.Empty;
            if (string.IsNullOrEmpty(inputRemark))
                return reStr;
            if (!inputRemark.Contains("@"))
                inputRemark = "@" + inputRemark;
            string[] remarkPorperys = inputRemark.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in remarkPorperys)
            {
                if (item.Contains("~"))
                {
                    string[] temp = item.Split(new char[] { '~' }, StringSplitOptions.RemoveEmptyEntries);
                    if (temp.Length == 2)
                    {
                        string t1 = temp[0];
                        string t2 = temp[1];
                        if (Regex.IsMatch(t1.Trim(), @"^\d+$"))
                        {
                            reStr += GetProductValById(t1) + "-";
                        }
                        else
                        {
                            reStr += t1 + "-";
                        }
                        reStr += t2 + "-";
                    }
                    else
                    {
                        reStr += item.Replace("~", "@");
                    }
                }
                else
                {
                    string[] temp = item.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    //if (temp.Length != 2) continue;
                    // string keyID = temp[0];
                    // string valID = temp[1];
                    string keyID = "";
                    string valID = "";

                    if (temp.Length == 2)
                    {
                        keyID = temp[0];
                        valID = temp[1];
                    }
                    else if (temp.Length > 2)
                    {
                        keyID = item.Substring(0, item.IndexOf('-'));
                        valID = item.Substring(item.IndexOf('-') + 1);
                    }
                    else
                        continue;

                    if (Regex.IsMatch(keyID.Trim(), @"^\d+$"))
                    {
                        reStr += GetOptionContentNameByID(keyID) + "-";
                    }
                    else
                    {
                        reStr += keyID + "-";
                    }
                    if (Regex.IsMatch(valID.Trim(), @"^\d+$"))
                    {
                        reStr += GetProductValById(valID) + "-";
                    }
                    else
                    {
                        reStr += valID + "-";
                    }
                }
                reStr = reStr.Trim('-') + "@";
            }
            reStr = reStr.Trim('@');


            if (string.IsNullOrEmpty(reStr))
            {
                return inputRemark;
            }
            else
            {
                return reStr;
            }
        }
        public static string GetProductValById(string id)
        {
            string sql = " select optionVal from tb_optionVal(nolock) where state in (2,-2) and id = " + id;
            object obj = SqlDbHelper.ExecuteScalar(sql);
            //这里这么写的意思是因为有些查不到的而原始输入的就是values
            if (obj != null)
            {
                return obj != null ? Convert.ToString(obj) : "";
            }
            return id;
        }

        public static string GetOptionContentNameByID(string id)
        {
            string sql = "  select b.name From TB_OptionContent a with(nolock) ,TB_Option2 b with(nolock) where a.OptionID = b.ID and a.ID =" + id;
            object obj = SqlDbHelper.ExecuteScalar(sql);
            return obj != null ? Convert.ToString(obj) : "";
        }

        public static string TranslateColor(string value, int LanguageID)
        {
            string result = value;

            string where = "1=2";
            if (LanguageID == 2) { where = "color_fr='" + value + "'"; }
            else if (LanguageID == 3) { where = "color_es='" + value + "'"; }

            string sql = "select * from TB_ColorInfo  with(nolock) where " + where;
            DataTable dt = SqlDbHelper.ExecuteDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    result = dr["Color_En"] + "";
                    break;
                }
            }
            return result;
        }

    }
}
