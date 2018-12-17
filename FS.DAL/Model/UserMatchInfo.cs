using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DAL.Model
{
    public class UserMatchInfo
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Gid { get; set; }
        public string Uid { get; set; }
        public string Web_id { get; set; }
        public string Archive { get; set; }
        public string All_balance { get; set; }
        public string Html { get; set; }
    }
    public class HtmlTable
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Gid { get; set; }
        public string Uid { get; set; }
        public string Html { get; set; }
    }
}
