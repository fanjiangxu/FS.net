using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.Crawler.Models
{
    public class FootBallResult
    {
        public decimal Match_Bmdy { get; set; }
        public decimal Match_Bgdy { get; set; }
        public decimal Match_Bhdy { get; set; }
        /// <summary>
        /// 1 主场胜 0 平 -1 负
        /// </summary>
        public int Match_ResultType { get; set; }
        public string TypeName { get; set; }
    }

    public class Match_Recommend
    {
        public string Match_Master { get; set; }
        public string Match_Guest { get; set; }
        public string Match_Date { get; set; }
        public decimal Match_Bmdy { get; set; }
        public decimal Match_Bgdy { get; set; }
        public DateTime AddDate { get; set; }
        /// <summary>
        /// 1 主场胜 0 平 -1 负
        /// </summary>
        public int Match_ResultType { get; set; }
    }
}
