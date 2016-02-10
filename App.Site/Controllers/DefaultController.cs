using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.IServices;
using App.Entity;

namespace App.Site.Controllers
{
    public class DefaultController : BaseController
    {
        public DefaultController(ICustomServices _ICustomServices)
        {
            base._ICustomServices = _ICustomServices;
        }
        public ActionResult Index()
        {
            _ICustomServices.Insert(new CustomModel
            {
                CustomName = "新生帝"
            });

            return View();
        }
    }
}