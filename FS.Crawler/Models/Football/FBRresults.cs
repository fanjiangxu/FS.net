using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wesley.Crawler.SimpleCrawler.Models.Football
{
    public class FBRresults
    {
        public string Match_Name { get; set; }
        public string Match_MatchTime { get; set; }
        public string Match_Master { get; set; }
        public string Match_Guest { get; set; }
        public string MB_Inball_HR { get; set; }
        public string MB_Inball { get; set; }
        public string TG_Inball_HR { get; set; }
        public string TG_Inball { get; set; }
        public DateTime AddDate { get; set; } = DateTime.Now;
    }
}