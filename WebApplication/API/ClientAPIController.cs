using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.API
{
    public class ClientAPIController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Client> Get()
        {
            IGenericRepository<Client> RepC = new GenericRepository<Client>();
            List<Client> ListC = RepC.GetAll().ToList();
            return ListC;
        }

        // GET api/<controller>/5
        public Client Get(int id)
        {
            IGenericRepository<Client> RepC = new GenericRepository<Client>();
            Client client = RepC.FindBy(item => item.idClient == id).FirstOrDefault();
            return client;

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