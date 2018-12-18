using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FS.Common
{
    public class StopwatchAttribute: ActionFilterAttribute
    {
        private const string StopwatchKey = "StopwatchFilter.Value";
        private readonly ILog  _logger = LogManager.GetLogger("loginfo");

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Items[StopwatchKey] = Stopwatch.StartNew();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var stopwatch = (Stopwatch)filterContext.HttpContext.Items[StopwatchKey];
            stopwatch.Stop();
            var log = string.Format("controller:{0},action:{1},execution time:{2}ms", filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, filterContext.ActionDescriptor.ActionName, stopwatch.ElapsedMilliseconds);
            _logger.Info(log);
        }
    }
}
