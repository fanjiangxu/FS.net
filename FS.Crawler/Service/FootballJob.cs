using log4net;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.Crawler.Service
{
    public class FootballJob: IJob
    {
        private readonly ILog log = LogManager.GetLogger("");
        public Task Execute(IJobExecutionContext context)
        {
            try
            {
                log.InfoFormat("TestJob测试");
                Console.WriteLine("TestJob测试");
            }
            catch (Exception e)
            {
                log.Error("error:" + DateTime.Now.ToString("yyyy-MM-dd") + "获取失败：" + e.Message, e);
            }
            return Task.FromResult(0);
        }
    }
}
