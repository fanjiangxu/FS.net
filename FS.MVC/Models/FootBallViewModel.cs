using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FS.MVC.Models
{
    public class FootBallViewModel
    {
        public decimal Match_Bmdy { get; set; }
        public decimal Match_Bgdy { get; set; }
        public decimal Match_Bhdy { get; set; }
        /// <summary>
        /// 1 主场胜 0 平 -1 负
        /// </summary>
        public int Match_ResultType { get; set; }
        public string TypeName { get; set;}
    }
}