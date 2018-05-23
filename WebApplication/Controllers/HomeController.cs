using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Mvc;
using DomainModel;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private IGenericRepository<Order> RepO = new GenericRepository<Order>();
        private IGenericRepository<Client> RepC = new GenericRepository<Client>();
        private IGenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();
        public ActionResult Index()
        {
            IEnumerable<Client> clients = RepC.GetAll();
            ViewBag.idClient = clients;
            var orders = RepO.GetAll().Include(o => o.Client).Include(o => o.ServiceType);
            return View(orders);
        }
    }
}
