﻿using FS.Common;
using FS.Common.Base;
using FS.MVC.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace FS.MVC.Controllers
{
    public class TestController : BaseController
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        [Stopwatch]
        public XmlResult GetUser()
        {
            var user = new UserViewModel()
            {
                Name = "richie",
                Age = 20,
                Email = "abc@126.com",
                Phone = "139********",
                Address = "my address"
            };
            return XmlView(user);
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}