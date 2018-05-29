using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.API
{
    public class ServiceTypeAPIController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<ServiceType> Get()
        {
            IGenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            List<ServiceType> ListST = RepST.GetAll().ToList();
            return ListST;
        }

        // GET api/<controller>/5
        public ServiceType Get(string id)
        {
            IGenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            ServiceType service = RepST.FindBy(item => item.nameService == id).FirstOrDefault();
            return service;
        }

        // POST api/<controller>
        public void Post([FromBody]ServiceType serviceType)
        {
            if (serviceType.priceService >=0 || serviceType.nameService != null)
            {
                IGenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
                RepST.Add(serviceType);
                RepST.Save();

            }
        }

        // PUT api/<controller>/5
        public void Put(/*string id, */[FromBody]ServiceType serviceType)
        {
            if (serviceType != null || serviceType.priceService >= 0)
            {
                IGenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
                RepST.Edit(serviceType);
                RepST.Save();
            }
        }

        // DELETE api/<controller>/5
        public void Delete(string id)
        {
            IGenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            ServiceType serviceType = RepST.FindBy(item => item.nameService == id).FirstOrDefault();
            RepST.Delete(serviceType);
            RepST.Save();
        }
    }
}