using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class C_CustomerContactDetailsController : Controller
    {
        private Customer db = new Customer();

        // GET: C_CustomerContactDetails
        public ActionResult Index()
        {
            return View(db.C_CustomerContactDetails.ToList());
        }

        // GET: C_CustomerContactDetails/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_CustomerContactDetails c_CustomerContactDetails = db.C_CustomerContactDetails.Find(id);
            if (c_CustomerContactDetails == null)
            {
                return HttpNotFound();
            }
            return View(c_CustomerContactDetails);
        }

        // GET: C_CustomerContactDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: C_CustomerContactDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustID,CustName,CustPhone,CustEmail,CustAddress,CustCity,PostalCode")] C_CustomerContactDetails c_CustomerContactDetails)
        {
            if (ModelState.IsValid)
            {
                db.C_CustomerContactDetails.Add(c_CustomerContactDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(c_CustomerContactDetails);
        }

        // GET: C_CustomerContactDetails/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_CustomerContactDetails c_CustomerContactDetails = db.C_CustomerContactDetails.Find(id);
            if (c_CustomerContactDetails == null)
            {
                return HttpNotFound();
            }
            return View(c_CustomerContactDetails);
        }

        // POST: C_CustomerContactDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustID,CustName,CustPhone,CustEmail,CustAddress,CustCity,PostalCode")] C_CustomerContactDetails c_CustomerContactDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c_CustomerContactDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c_CustomerContactDetails);
        }

        // GET: C_CustomerContactDetails/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            C_CustomerContactDetails c_CustomerContactDetails = db.C_CustomerContactDetails.Find(id);
            if (c_CustomerContactDetails == null)
            {
                return HttpNotFound();
            }
            return View(c_CustomerContactDetails);
        }

        // POST: C_CustomerContactDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            C_CustomerContactDetails c_CustomerContactDetails = db.C_CustomerContactDetails.Find(id);
            db.C_CustomerContactDetails.Remove(c_CustomerContactDetails);
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
