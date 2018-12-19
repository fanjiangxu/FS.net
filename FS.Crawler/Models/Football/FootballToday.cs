using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wesley.Crawler.SimpleCrawler.Models.Football
{
   public class FootballToday
    {
        public string Match_ID { get; set; }

        public string SMM { get; set; }

        public string Match_Master { get; set; }

        public string Match_Guest { get; set; }

        public string Match_Name { get; set; }

        public string Match_Date { get; set; }

        public string Match_BzM { get; set; }

        public string Match_Ho { get; set; }

        public string Match_DxDpl { get; set; }

        public string Match_DsDpl { get; set; }

        public string Match_BzG { get; set; }

        public string Match_Ao { get; set; }

        public string Match_DxXpl { get; set; }

        public string Match_DsSpl { get; set; }

        public string Match_BzH { get; set; }

        public string Match_RGG { get; set; }

        public string Match_DxGG1 { get; set; }

        public string Match_ShowType { get; set; }

        public string Match_DxGG2 { get; set; }

        public string Match_Bmdy { get; set; }

        public string Match_BHo { get; set; }

        public string Match_Bdpl { get; set; }

        public string Match_Bgdy { get; set; }

        public string Match_BAo { get; set; }

        public string Match_Bxpl { get; set; }

        public string Match_Bhdy { get; set; }

        public string Match_BRpk { get; set; }

        public string Match_Bdxpk1 { get; set; }

        public string Match_Hr_ShowType { get; set; }

        public string Match_Bdxpk2 { get; set; }

        public DateTime AddDate
        {
            get
            {
                return DateTime.Now;
            }
            set { }
        }
    }
}

