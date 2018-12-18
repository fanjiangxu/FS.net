using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FS.Common.Base
{
    public class BaseController:Controller
    {
        protected readonly ILog _logger =LogSingleton.GetInstance()._logger;
        protected XmlResult XmlView(object data)
        {
            return new XmlResult(data);
        }
    }
}
