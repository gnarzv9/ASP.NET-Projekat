using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PSA_Projekat.Models;

namespace PSA_Projekat.Controllers
{
    public class OpremasController : Controller
    {
        private Model1 db = new Model1();

        public ActionResult Index()
        {
            return View(db.Opremas.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oprema oprema = db.Opremas.Find(id);
            if (oprema == null)
            {
                return HttpNotFound();
            }
            return View(oprema);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Sifra,Naziv,Proizvodjac,Kolicina,TezinaKilograms")] Oprema oprema)
        {
            if (ModelState.IsValid)
            {
                db.Opremas.Add(oprema);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oprema);
        }

  
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oprema oprema = db.Opremas.Find(id);
            if (oprema == null)
            {
                return HttpNotFound();
            }
            return View(oprema);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Sifra,Naziv,Proizvodjac,Kolicina,TezinaKilograms")] Oprema oprema)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oprema).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oprema);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Oprema oprema = db.Opremas.Find(id);
            if (oprema == null)
            {
                return HttpNotFound();
            }
            return View(oprema);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Oprema oprema = db.Opremas.Find(id);
            db.Opremas.Remove(oprema);
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
