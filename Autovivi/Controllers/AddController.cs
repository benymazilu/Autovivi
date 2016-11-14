using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Autovivi.Models;
using System.IO;

namespace Autovivi.Controllers
{
    public class AddController : Controller
    {
        private AutoviviDbContext db = new AutoviviDbContext();

        // GET: Add
        public ActionResult Index()
        {
            return View(db.Adds.ToList());
        }

        // GET: Add/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Add add = db.Adds.Find(id);
            if (add == null)
            {
                return HttpNotFound();
            }
            return View(add);
        }

        [Authorize]
        // GET: Add/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Add/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] Add add)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {

                    foreach (string inputName in Request.Files)
                    {
                        HttpPostedFileBase file = Request.Files[inputName];
                        if (file != null && file.ContentLength > 0)
                        {
                            var fileName = Path.GetFileName(file.FileName);
                            var path = Path.Combine(Server.MapPath("~/Images/"), fileName);
                            file.SaveAs(path);
                        }
                    }
                }
                add.PostDate = DateTime.Now;
                    db.Adds.Add(add);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(add);
        }

        // GET: Add/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Add add = db.Adds.Find(id);
            if (add == null)
            {
                return HttpNotFound();
            }
            return View(add);
        }

        // POST: Add/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] Add add)
        {
            if (ModelState.IsValid)
            {
                db.Entry(add).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(add);
        }

        // GET: Add/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Add add = db.Adds.Find(id);
            if (add == null)
            {
                return HttpNotFound();
            }
            return View(add);
        }

        // POST: Add/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Add add = db.Adds.Find(id);
            db.Adds.Remove(add);
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

        //[HttpPost]
        //public ActionResult Upload(HttpPostedFileBase photo)
        //{
        //    string directory = @"E:\Temp\";

        //    if (photo != null && photo.ContentLength > 0)
        //    {
        //        var fileName = Path.GetFileName(photo.FileName);
        //        photo.SaveAs(Path.Combine(directory, fileName));
        //    }

        //    return RedirectToAction("Index");
        //}
        [HttpPost]
        public ActionResult Upload()
        {
            if (Request.Files.Count > 0)
            {
           
                    foreach (string inputName in Request.Files)
                    {
                        HttpPostedFileBase file = Request.Files[inputName];
                        if (file != null && file.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/Images/"), fileName);
                        file.SaveAs(path);
                    }
                }
            }
            return null; 

        }
    }
}

