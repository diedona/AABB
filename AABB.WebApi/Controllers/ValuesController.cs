using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AABB.WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        public IHttpActionResult Get()
        {
            string[] foo = new string[] { "foo", "bar", "miz" };
            return Ok(foo);
        }
    }
}
