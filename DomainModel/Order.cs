using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Order
    {
        [Key]
        public int idOrder { get; set; }
        public string lawnAdress { get; set; }
        public float lawnArea { get; set; }
        public float totalCost { get; set; }
        public DateTime orderTime { get; set; }

        [ForeignKey("Client")]
        public int idClient { get; set; }
        public Client Client { get; set; }

        [ForeignKey("ServiceType")]
        public string nameService { get; set; }
        public ServiceType ServiceType { get; set; }

        public Order() { }

        public Order(string nameService, float lawnArea)
        {
            GenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
            this.totalCost = lawnArea * RepST.FindBy(item => item.nameService == nameService).FirstOrDefault().priceService;
            this.nameService = nameService;
            this.orderTime = DateTime.Now;
            this.lawnArea = lawnArea;
        }
    }
}
