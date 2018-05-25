using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class DataContext : DbContext
    {
        public DbSet<Order> orders { get; set; }
        public DbSet<ServiceType> serviceTypes { get; set; }
        public DbSet<Client> сlients { get; set; }

        public DataContext() : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LawnDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }
     
    }
}
