using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class ServiceType
    {
        [Key]
        public string nameService { get; set; }
        public float priceService { get; set; }

    }
}
