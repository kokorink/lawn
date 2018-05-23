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
    public class ServiceTypesController : Controller
    {
        private IGenericRepository<ServiceType> repST = new GenericRepository<ServiceType>() ;

        // GET: ServiceTypes
        public ActionResult Index()
        {
            return View(repST);
        }

        // GET: ServiceTypes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceType serviceType = repST.FindBy(item => item.nameService == id).FirstOrDefault();
            if (serviceType == null)
            {
                return HttpNotFound();
            }
            return View(serviceType);
        }

        // GET: ServiceTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceTypes/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nameService,priceService")] ServiceType serviceType)
        {
            if (ModelState.IsValid)
            {
                repST.Add(serviceType);
                repST.Save();
                return RedirectToAction("Index");
            }

            return View(serviceType);
        }

        // GET: ServiceTypes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceType serviceType = repST.FindBy(item => item.nameService == id).FirstOrDefault();
            if (serviceType == null)
            {
                return HttpNotFound();
            }
            return View(serviceType);
        }

        // POST: ServiceTypes/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "nameService,priceService")] ServiceType serviceType)
        {
            if (ModelState.IsValid)
            {
                repST.Edit(serviceType);
                repST.Save();
                return RedirectToAction("Index");
            }
            return View(serviceType);
        }

        // GET: ServiceTypes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceType serviceType = repST.FindBy(item => item.nameService == id).FirstOrDefault();
            if (serviceType == null)
            {
                return HttpNotFound();
            }
            return View(serviceType);
        }

        // POST: ServiceTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ServiceType serviceType = repST.FindBy(item => item.nameService == id).FirstOrDefault();
            repST.Delete(serviceType);
            repST.Save();
            return RedirectToAction("Index");
        }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }
    }
}
