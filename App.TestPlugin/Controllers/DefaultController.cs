using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.TestPlugin.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.pluginName = "插件名称：TestPlugin，我本来是App.TestPlugin项目的";
            return View();
        }
    }
}