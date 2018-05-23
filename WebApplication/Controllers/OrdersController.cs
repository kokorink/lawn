using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DomainModel;

namespace WebApplication.Controllers
{
    public class OrdersController : Controller
    {
        private IGenericRepository<Order> RepO = new GenericRepository<Order>();
        private IGenericRepository<Client> RepC = new GenericRepository<Client>();
        private IGenericRepository<ServiceType> RepST = new GenericRepository<ServiceType>();

        // GET: Orders
        public ActionResult Index()
        {
            IEnumerable<Client> clients = RepC.GetAll();
            ViewBag.idClient = clients;
            var orders = RepO.GetAll().Include(o => o.Client).Include(o => o.ServiceType);
            return View(orders);
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IEnumerable<Client> clients = RepC.GetAll();
            ViewBag.idClient = clients;
            Order order = RepO.FindBy(item => item.idOrder == id).FirstOrDefault();
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            ViewBag.idClient = new SelectList(RepC.GetAll(), "idClient", "clientName");
            ViewBag.nameService = new SelectList(RepST.GetAll(), "nameService", "nameService");
            return View();
        }

        // POST: Orders/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idOrder,lawnAdress,lawnArea,totalCost,orderTime,idClient,nameService")] Order order)
        {
            if (ModelState.IsValid)
            {

                Order orderAdd = new Order(order.nameService, order.lawnArea);
                order.totalCost = orderAdd.totalCost;
                order.orderTime = orderAdd.orderTime;


                RepO.Add(order);
                RepO.Save();
                return RedirectToAction("Index");
            }

            ViewBag.idClient = new SelectList(RepC.GetAll(), "idClient", "clientName", order.idClient);
            ViewBag.nameService = new SelectList(RepST.GetAll(), "nameService", "nameService", order.nameService);
            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = RepO.FindBy(item => item.idOrder == id).FirstOrDefault();
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.idClient = new SelectList(RepC.GetAll(), "idClient", "clientName", order.idClient);
            ViewBag.nameService = new SelectList(RepST.GetAll(), "nameService", "nameService", order.nameService);
            return View(order);
        }

        // POST: Orders/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idOrder,lawnAdress,lawnArea,totalCost,orderTime,idClient,nameService")] Order order)
        {
            if (ModelState.IsValid)
            {
                Order newOrder = new Order(order.nameService, order.lawnArea);
                order.totalCost = newOrder.totalCost;
                RepO.Edit(order);
                RepO.Save();
                return RedirectToAction("Index");
            }
            ViewBag.idClient = new SelectList(RepC.GetAll(), "idClient", "clientName", order.idClient);
            ViewBag.nameService = new SelectList(RepST.GetAll(), "nameService", "nameService", order.nameService);
            return View(order);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IEnumerable<Client> clients = RepC.GetAll();
            ViewBag.idClient = clients;
            Order order = RepO.FindBy(item => item.idOrder == id).FirstOrDefault();
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = RepO.FindBy(item => item.idOrder == id).FirstOrDefault();
            RepO.Delete(order);
            RepO.Save();
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
