using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FS.Common.Filter
{
    public class Log4NetExceptionFilter: IExceptionFilter
    {
        private readonly ILog _logger;

        public Log4NetExceptionFilter()
        {
            _logger = LogSingleton.GetInstance().log;
        }
        public void OnException(ExceptionContext context)
        {
            _logger.Error("Unhandled exception", context.Exception);
        }
    }
}
