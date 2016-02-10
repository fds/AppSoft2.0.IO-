using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using App.Entity;
using App.IServices;

namespace App.RESTful_API.Controllers
{
    public class DefaultController : BaseApiController
    {
        public DefaultController(ICustomServices _ICustomServices)
        {
            base._ICustomServices = _ICustomServices;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            _ICustomServices.Insert(new CustomModel()
            {
                CustomName = "哈哈哈"
            });
            return new string[] { "value1", "value2" };
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