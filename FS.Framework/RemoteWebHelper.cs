using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FS.Framework
{
    public static class RemoteWebHelper
    {
        /// <summary>  
        /// 获取页面类容  
        /// </summary>  
        /// <param name="strUrl"></param>  
        /// <returns></returns>  
        public static string GetHtml(string strUrl)
        {

            WebRequest request = WebRequest.Create(strUrl);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string str = reader.ReadToEnd();
            reader.Close();
            reader.Dispose();
            response.Close();
            return str;

        }
    }
}
