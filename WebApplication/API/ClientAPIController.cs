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
        public void Post([FromBody]Client client)
        {
            if (client.clientName != null || client.clientPhone != null)
            {
                IGenericRepository<Client> RepC = new GenericRepository<Client>();
                RepC.Add(client);
                RepC.Save();

            }
        }

        // PUT api/<controller>/5
        public void Put(/*int id, */[FromBody]Client client)
        {
            if (client != null || client.clientName != null || client.clientPhone != null)
            {
                IGenericRepository<Client> RepC = new GenericRepository<Client>();
                RepC.Edit(client);
                RepC.Save();
            }
        }


        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            IGenericRepository<Client> RepС = new GenericRepository<Client>();
            Client сlient = RepС.FindBy(item => item.idClient == id).FirstOrDefault();
            RepС.Delete(сlient);
            RepС.Save();
        }
    }
}