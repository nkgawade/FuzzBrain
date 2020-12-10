using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FuzzBrain.Models;

namespace FuzzBrain.Controllers
{    
    public class POCsController : Controller
    {
        private FuzzBrainDBContext db = new FuzzBrainDBContext();

        // GET: POCs
        [Authorize(Roles = "Admin,User")]
        public ActionResult Index()
        {
            var pOCs = db.POCs.Include(p => p.Employee);
            return View(pOCs.ToList());
        }

        // GET: POCs/Details/5
        [Authorize(Roles = "Admin,User")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            POC pOC = db.POCs.Find(id);
            if (pOC == null)
            {
                return HttpNotFound();
            }
            return View(pOC);
        }

        // GET: POCs/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name");
            return View();
        }

        // POST: POCs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "POCID,Title,Description,Complexity,EmployeeId")] POC pOC)
        {
            if (ModelState.IsValid)
            {
                db.POCs.Add(pOC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name", pOC.EmployeeId);
            return View(pOC);
        }

        // GET: POCs/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            POC pOC = db.POCs.Find(id);
            if (pOC == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name", pOC.EmployeeId);
            return View(pOC);
        }

        // POST: POCs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "POCID,Title,Description,Complexity,EmployeeId")] POC pOC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pOC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name", pOC.EmployeeId);
            return View(pOC);
        }

        // GET: POCs/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            POC pOC = db.POCs.Find(id);
            if (pOC == null)
            {
                return HttpNotFound();
            }
            return View(pOC);
        }

        // POST: POCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            POC pOC = db.POCs.Find(id);
            db.POCs.Remove(pOC);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: POCs/AssignPOC/5
        [HttpPost, ActionName("AssignPOC")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,User")]
        public ActionResult AssignPOC(int id)
        {            
            POC pOC = db.POCs.Find(id);
            db.POCs.Add(pOC);
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
