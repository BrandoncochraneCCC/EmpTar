using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmpTar.Models;

namespace EmpTar.Controllers
{
    public class EmployeeTargetsController : Controller
    {
        private EmployeeTargetDBContext db = new EmployeeTargetDBContext();

        // GET: EmployeeTargets
        public ActionResult Index()
        {
            return View(db.EmployeeTargets.ToList());
        }

        // GET: EmployeeTargets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTarget employeeTarget = db.EmployeeTargets.Find(id);
            if (employeeTarget == null)
            {
                return HttpNotFound();
            }
            return View(employeeTarget);
        }

        // GET: EmployeeTargets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeTargets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,EmployeeID,Month,Year,TargetHour")] EmployeeTarget employeeTarget)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeTargets.Add(employeeTarget);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeTarget);
        }

        // GET: EmployeeTargets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTarget employeeTarget = db.EmployeeTargets.Find(id);
            if (employeeTarget == null)
            {
                return HttpNotFound();
            }
            return View(employeeTarget);
        }

        // POST: EmployeeTargets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,EmployeeID,Month,Year,TargetHour")] EmployeeTarget employeeTarget)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeTarget).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeTarget);
        }

        // GET: EmployeeTargets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeTarget employeeTarget = db.EmployeeTargets.Find(id);
            if (employeeTarget == null)
            {
                return HttpNotFound();
            }
            return View(employeeTarget);
        }

        // POST: EmployeeTargets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeTarget employeeTarget = db.EmployeeTargets.Find(id);
            db.EmployeeTargets.Remove(employeeTarget);
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
