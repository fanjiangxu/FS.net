using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.DAL.Model
{
    public class Match
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Num { get; set; }
        public string RateStr { get; set; }
        public decimal Rate
        {
            get
            {
                return Convert.ToDecimal(RateStr.Replace("%", ""));
            }
            set { }
        }
        public DateTime CreateTime { get; set; }
        public int MatchID { get; set; }
        public string IntroduceUrl { get; set; }
        public string TopUrl { get; set; }

        public decimal BaseMoney { get; set; }
    }
}
