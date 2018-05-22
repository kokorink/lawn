﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Client
    {
        [Key]
        public int idClient { get; set; }
        public string clientName { get; set; }
        public string clientPhone { get; set; }
    }
}
