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
    public class ClientsController : Controller
    {
        private IGenericRepository<Client> repC = new GenericRepository<Client>();

        // GET: Clients
        public ActionResult Index()
        {

            return View(repC);
        }

        // GET: Clients/Details/5
        public ActionResult Details(int id)
        {
            repC.GetAll();
            Client client = new Client();
            client = repC.FindBy(item => item.idClient == id).FirstOrDefault();
            return View(client);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idClient,clientName,clientPhone")] Client client)
        {
            if (ModelState.IsValid)
            {
                repC.GetAll();
                repC.Add(client);
                repC.Save();
                return RedirectToAction("Index");
            }

            return View(client);
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            repC.GetAll();
            Client client = repC.FindBy(item => item.idClient == id).FirstOrDefault();
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idClient,clientName,clientPhone")] Client client)
        {
            repC.GetAll();
            repC.Edit(client);
            repC.Save();
            return RedirectToAction("Index");
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            repC.GetAll();
            Client client = repC.FindBy(item => item.idClient == id).FirstOrDefault();
            if (client == null)
                return HttpNotFound();
            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repC.GetAll();
            Client client = repC.FindBy(item => item.idClient == id).FirstOrDefault();
            repC.Delete(client);
            repC.Save();
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
