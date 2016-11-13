using diveSiteProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace diveSiteProject.Controllers
{
    public class HomeController : Controller
    {
        diveSitesDBEntities db = new diveSitesDBEntities();

        // Landing Page
        public ActionResult Index()
        {
            return View();
        }

        // List of all of the records
        public ActionResult DiveSite()
        {
            var sites = from s in db.DiveSite
                        select s;
            return View(sites);
        }
        
        // Edit Existing DiveSite View
        public ActionResult edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiveSite record = db.DiveSite.Find(Id);
            if (record == null)
            {
                return HttpNotFound();
            }
            return View(record);
        }

        [HttpPost, ActionName("edit")] // Edit record in database
        [ValidateAntiForgeryToken]
        public ActionResult editRecord(DiveSite record)
        {
            if (ModelState.IsValid)
            {
                db.Entry(record).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DiveSite");
            }
            return View();
        }

        // Confirm Delete DiveSite View
        public ActionResult delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiveSite record = db.DiveSite.Find(Id);
            if (record == null)
            {
                return HttpNotFound();
            }
            return View(record);
        }

        [HttpPost, ActionName("delete")] // Delete record from database
        public ActionResult deleteRecord(int id)
        {
            DiveSite record = db.DiveSite.Find(id);
            db.DiveSite.Remove(record);
            db.SaveChanges();
            return RedirectToAction("DiveSite");
        }

        // Indivudal Detailed DiveSite View
        public ActionResult details(int? Id)
        { 
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiveSite record = db.DiveSite.Find(Id);
            if (record == null)
            {
                return HttpNotFound();
            }
            return View(record);
        }

        // View to Add new DiveSite Record
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]  // Add new record to database
        [ValidateAntiForgeryToken]
        public ActionResult Add(DiveSite record)
        {
            if (ModelState.IsValid)
            {
                db.DiveSite.Add(record);
                db.SaveChanges();
                return RedirectToAction("DiveSite");
            }
            return View();
        }

    } // END OF CLASS
} //END OF NAMESPACE