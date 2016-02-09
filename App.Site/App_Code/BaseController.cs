using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.IServices;
using System.Web.Mvc;

namespace App.Site
{
    public class BaseController : Controller
    {
        protected ICustomServices _ICustomServices;
    }
}