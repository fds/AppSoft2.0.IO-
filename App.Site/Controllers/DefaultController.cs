using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Entity;
using App.IServices;

namespace App.Site.Controllers
{
    // 继承BaseController
    public class DefaultController : BaseController
    {
        // 构造方法注入
        public DefaultController(IUserServices _IUserServices)
        {
            base._IUserServices = _IUserServices;
        }

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}