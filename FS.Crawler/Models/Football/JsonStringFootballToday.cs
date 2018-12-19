using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wesley.Crawler.SimpleCrawler.Models.Football
{
    public class JsonStringFootballToday
    {
        public int Page { get; set; }

        public string[] Legname { get; set; }

        public List<FootballToday> DB { get; set; }
    }
}
