using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webapi_crud1.Models;

namespace webapi_crud1.Controllers
{
    public class studController : Controller
    {
        // GET: stud
        private demodbEntities db = new demodbEntities();
        public ActionResult Index()
        {
            return View(db.students.ToList());
        }

        // GET: stud/Details/5
        public ActionResult Details(int? id)
        {
            //if (id == null)
            //{
            //    student student = db.students.Find(id);
            //    if (student == null)
            //    {
            //        return HttpNotFound();
            //    }
            //    return View(student);
            //}
            //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return View();
        }

        // GET: stud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: stud/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,sname,course,fees")] student student)
        {
            if (ModelState.IsValid)
            {
                db.students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: stud/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            student student = db.students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: stud/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "id,sname,course,fees")] student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: stud/Delete/5
        public ActionResult Delete(int? id)
        {
            student student = db.students.SingleOrDefault(m => m.id == id);
            if (id == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: stud/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id,student s)
        {
            student student = db.students.Find(id);
            db.students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
