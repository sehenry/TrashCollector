using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class TrashWorkersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TrashWorkers
        public ActionResult Index()
        {
            var trashWorkers = db.TrashWorkers.Include(t => t.User);
            return View(trashWorkers.ToList());
        }

        // GET: TrashWorkers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrashWorker trashWorker = db.TrashWorkers.Find(id);
            if (trashWorker == null)
            {
                return HttpNotFound();
            }
            return View(trashWorker);
        }

        // GET: TrashWorkers/Create
        public ActionResult Create()
        {
            ViewBag.ApplicationUserId = new SelectList(db.ApplicationUsers, "Id", "Email");
            return View();
        }

        // POST: TrashWorkers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrashWorkerId,firstName,lastName,email,password,routeZipCode,trashWorkDay,ApplicationUserId")] TrashWorker trashWorker)
        {
            if (ModelState.IsValid)
            {
                db.TrashWorkers.Add(trashWorker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ApplicationUserId = new SelectList(db.ApplicationUsers, "Id", "Email", trashWorker.ApplicationUserId);
            return View(trashWorker);
        }

        // GET: TrashWorkers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrashWorker trashWorker = db.TrashWorkers.Find(id);
            if (trashWorker == null)
            {
                return HttpNotFound();
            }
            ViewBag.ApplicationUserId = new SelectList(db.ApplicationUsers, "Id", "Email", trashWorker.ApplicationUserId);
            return View(trashWorker);
        }

        // POST: TrashWorkers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TrashWorkerId,firstName,lastName,email,password,routeZipCode,trashWorkDay,ApplicationUserId")] TrashWorker trashWorker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trashWorker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ApplicationUserId = new SelectList(db.ApplicationUsers, "Id", "Email", trashWorker.ApplicationUserId);
            return View(trashWorker);
        }

        // GET: TrashWorkers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrashWorker trashWorker = db.TrashWorkers.Find(id);
            if (trashWorker == null)
            {
                return HttpNotFound();
            }
            return View(trashWorker);
        }

        // POST: TrashWorkers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TrashWorker trashWorker = db.TrashWorkers.Find(id);
            db.TrashWorkers.Remove(trashWorker);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
