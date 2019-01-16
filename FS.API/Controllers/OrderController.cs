using FS.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FS.API.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrderController : ApiController
    {
        [Authorize]
        [Route("")]
        public List<Order> Get()
        {
            return Order.CreateOrders();
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