using crud_linq.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
namespace crud_linq.Controllers
{
    public class usController : Controller
    {
        // GET: user
        usClassDataContext db = new usClassDataContext();
        public ActionResult Index()
        {
            IList<user> userlist = new List<user>();
            var query = from qrs in db.users select qrs;
            var listdata = query.ToList();
            foreach(var userdata in listdata)
            {
                userlist.Add(new user()
                {
                    id = userdata.id,
                    name=userdata.name
                });
            
            } 

            return View(userlist);
        }

        // GET: user/Details/5
        public ActionResult Details(int id)
        {
            user u = db.users.Where(val => val.id == id).Select(val => new user()
            {
                id=val.id,
                name=val.name,
            }).SingleOrDefault();
            return View(u);
        }

        // GET: user/Create
        public ActionResult Create()
        {
            user us = new user();
            return View(us);
        }

        // POST: user/Create
        [HttpPost]
        public ActionResult Create(user u)
        {
            user uu = new user();
            uu.id = u.id;
            uu.name = u.name;
            db.users.InsertOnSubmit(uu);
            db.SubmitChanges();
            return RedirectToAction("Index");
            
        }

        // GET: user/Edit/5
        public ActionResult Edit(int id)
        {
            user model = db.users.Where(val => val.id == id).Select(val => new user()
            {
                id = val.id,
                name = val.name
            }).SingleOrDefault();
            return View(model);
        }

        // POST: user/Edit/5
        [HttpPost]
        public ActionResult Edit(user u)
        {
            user us = db.users.Where(val => val.id == u.id).Single<user>();
            us.id = u.id;
            us.name = u.name;
            db.SubmitChanges();
            return RedirectToAction("index");
            
        }

        // GET: user/Delete/5
        public ActionResult Delete(int id)
        {
            user u = db.users.Where(val => val.id == id).Select(val => new user()
            {
                id = val.id,
                name = val.name
            }).SingleOrDefault();
            return View(u);
        }

        // POST: user/Delete/5
        [HttpPost]
        public ActionResult Delete(user u)
        {

            user us = db.users.Where(val => val.id == u.id).Single<user>();
            db.users.DeleteOnSubmit(us);
            db.SubmitChanges();
            return RedirectToAction("Index");
            
        }
    }
}
