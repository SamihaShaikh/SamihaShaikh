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
    public class empController : Controller
    {
        private demodbEntities db = new demodbEntities();
        // GET: emp
        public ActionResult Index()
        {
            return View(db.emps.ToList());
        }

        // GET: emp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: emp/Create
        [HttpPost]
        public ActionResult Create([Bind(Include ="id,ename,desgn")]emp emp)
        {
            if(ModelState.IsValid)
            {
                db.emps.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        // GET: emp/Edit/5
        public ActionResult Edit(int? id)
        {
            emp emp = db.emps.Find(id);
            if(emp==null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: emp/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "id,ename,desgn")] emp emp)
        {
            if(ModelState.IsValid)
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(emp);
        }

        // GET: emp/Delete/5
        public ActionResult Delete(int? id)
        {
            emp emp = db.emps.Find(id);
            if(emp==null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: emp/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,emp e)
        {
            emp emp = db.emps.Find(id);
            db.emps.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
