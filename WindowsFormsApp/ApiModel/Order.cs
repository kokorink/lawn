using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Order
    {
        public int idOrder { get; set; }
        public string lawnAdress { get; set; }
        public float lawnArea { get; set; }
        public float totalCost { get; set; }
        public DateTime orderTime { get; set; }
        public int idClient { get; set; }
        public string nameService { get; set; }
    }
}
