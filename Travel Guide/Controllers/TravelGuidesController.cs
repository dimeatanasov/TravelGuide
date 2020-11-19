using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Travel_Guide.Models;

namespace Travel_Guide.Controllers
{
    public class TravelGuidesController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: TravelGuides
        public ActionResult Index()
        {
            return View(db.travelGuides.ToList());
        }

        // GET: TravelGuides/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TravelGuide travelGuide = db.travelGuides.Find(id);
            var model = new TravelGuide();
            model.Id = travelGuide.Id;
            model.name = travelGuide.name;
            model.restaurants = db.Restaurants.ToList();
            model.galleries = db.Galleries.ToList();
            model.hotels = db.Hotels.ToList();
            if (travelGuide == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // GET: TravelGuides/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TravelGuides/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,name,backgroundPicture")] TravelGuide travelGuide)
        {
            if (ModelState.IsValid)
            {
                db.travelGuides.Add(travelGuide);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(travelGuide);
        }

        // GET: TravelGuides/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TravelGuide travelGuide = db.travelGuides.Find(id);
            if (travelGuide == null)
            {
                return HttpNotFound();
            }
            return View(travelGuide);
        }

        // POST: TravelGuides/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,name,backgroundPicture")] TravelGuide travelGuide)
        {
            if (ModelState.IsValid)
            {
                db.Entry(travelGuide).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(travelGuide);
        }

        // GET: TravelGuides/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TravelGuide travelGuide = db.travelGuides.Find(id);
            if (travelGuide == null)
            {
                return HttpNotFound();
            }
            return View(travelGuide);
        }

        // POST: TravelGuides/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TravelGuide travelGuide = db.travelGuides.Find(id);
            db.travelGuides.Remove(travelGuide);
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
