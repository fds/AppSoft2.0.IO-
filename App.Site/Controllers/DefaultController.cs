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
        public DefaultController(ICustomServices __ICustomServices)
        {
            base._ICustomServices = __ICustomServices;
        }
        // GET: Default
        public ActionResult Index()
        {
            CustomModel entity = new CustomModel()
            {
                CustomName = "新生帝"
            };

            _ICustomServices.Insert(entity);

            return View();
        }
    }
}