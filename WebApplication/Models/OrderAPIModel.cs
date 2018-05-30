using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class OrderAPIModel
    {
        //public int idOrder { get; set; }
        //public string lawnAdress { get; set; }
        //public float lawnArea { get; set; }
        //public float totalCost { get; set; }
        //public DateTime orderTime { get; set; }
        //public int idClient { get; set; }
        //public string nameService { get; set; }
        public List<Order> ordersList { get; set; }
        public List<string> nameServiceList { get; set; }
        public List<int> idClientList { get; set; }

        public OrderAPIModel(List<Order> ordersList)
        {
            this.ordersList = ordersList;
            IGenericRepository<Client> RepC = new GenericRepository<Client>();
            IGenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            List<Client> ListC = RepC.GetAll().ToList();
            List<ServiceType> ListST = RepST.GetAll().ToList();
            List<string> nameServiceList = new List<string>();
            foreach (ServiceType item in ListST)
            {
                nameServiceList.Add(item.nameService);
            }
            this.nameServiceList = nameServiceList;
            List<int> idClientList = new List<int>();
            foreach (Client item in ListC)
            {
                idClientList.Add(item.idClient);
            }
            this.idClientList = idClientList;

        }

    }
}