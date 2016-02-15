using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using App.Entity;
using App.IServices;
using App.Vector;

namespace App.RESTful_API.Controllers
{
    // 继承BaseApiController
    public class ApiDefaultController : BaseApiController
    {
        readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // 构造方法注入
        public ApiDefaultController(IUserServices _IUserServices)
        {
            base._IUserServices = _IUserServices;
        }

        // GET api/<controller>
        public List<UserEntity> Get()
        {
            return _IUserServices.QueryByWherePage(1, 20, c => true, "UserID desc");
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}