using DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;

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
        public Order Get(int id)
        {
            IGenericRepository<Order> RepO = new GenericRepository<Order>();
            Order order = RepO.FindBy(item => item.idOrder == id).FirstOrDefault();
            return order;
        }

        // POST api/<controller>
        public void Post([FromBody]Order order)
        {
            if (order.lawnAdress!= null || order.lawnArea >= 0)
            {
                Order newOrder = new Order(order.nameService, order.lawnArea) { idClient = order.idClient, lawnAdress = order.lawnAdress };
                IGenericRepository<Order> RepO = new GenericRepository<Order>();
                RepO.Add(newOrder);
                RepO.Save();

            }
        }

        // PUT api/<controller>/5
        public void Put(/*int id, */[FromBody]Order order)
        {
            if (order.lawnAdress != null || order.lawnArea >= 0)
            {
                Order newOrder = new Order(order.nameService, order.lawnArea);
                order.totalCost = newOrder.totalCost;
                IGenericRepository<Order> RepO = new GenericRepository<Order>();
                RepO.Edit(order);
                RepO.Save();
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            IGenericRepository<Order> RepO = new GenericRepository<Order>();
            Order order = RepO.FindBy(item => item.idOrder == id).FirstOrDefault();
            RepO.Delete(order);
            RepO.Save();
        }
    }
}