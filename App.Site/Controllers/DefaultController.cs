using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Entity;
using App.IServices;

namespace App.Site.Controllers
{
    public class DefaultController : BaseController
    {
        public DefaultController(ICustomServices _ICustomServices)
        {
            base._ICustomServices = _ICustomServices;
        }
        // GET: Default
        public ActionResult Index()
        {
            _ICustomServices.Insert(new CustomModel()
            {
                CustomName = "哈哈哈222"
            });

            return View();
        }
    }
}