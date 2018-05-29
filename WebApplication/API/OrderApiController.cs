using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.API
{
    public class OrderApiController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Order> Get()
        {
            IGenericRepository<Order> RepO = new GenericRepository<Order>();
            List<Order> ListO = RepO.GetAll().ToList();
            return ListO;
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