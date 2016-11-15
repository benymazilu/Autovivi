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
using Autovivi.Models.BrandModelEnums;

namespace Autovivi.Controllers
{
    public class AddController : Controller
    {
        private AutoviviDbContext db = new AutoviviDbContext();

        [Authorize]
        // GET: Add
        public ActionResult Index()
        {
            var username = User.Identity.Name;
            var myAdds = db.Adds.Include("Vehicle").Include("User").Where(a => a.CreatedByName == username).ToList();
            return View(myAdds);
        }

        [Authorize]
        // GET: Add/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Add add = db.Adds.Include("Vehicle").Include("User").Where(a => a.Id == id).FirstOrDefault();
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
        public ActionResult Create([Bind(Include = "Vehicle,User")] Add add, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                //db.Adds.Add(add);

                    if (file!=null && file.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/uploads"), fileName);
                        file.SaveAs(path);
                        add.ImageName = fileName;
                    }
                add.CreatedByName = User.Identity.Name;
                add.PostDate = DateTime.Now;
                db.Adds.Add(add);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(add);
        }

        [Authorize]
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

        public JsonResult ModelList([Bind(Prefix = "id")] string brand)
        {
            Type brandEnumType = typeof(Dacia);
            switch (brand)
            {
                case "Acura":
                    brandEnumType = typeof(Acura);
                    break;

                case "Audi":
                    brandEnumType = typeof(Audi);
                    break;

                case "Alfa Romeo":
                    brandEnumType = typeof(AlfaRomeo);
                    break;

                case "Bentley":
                    brandEnumType = typeof(Bentley);
                    break;

                case "BMW":
                    brandEnumType = typeof(BMW);
                    break;

                case "Cadillac":
                    brandEnumType = typeof(Cadillac);
                    break;

                case "Chevrolet":
                    brandEnumType = typeof(Chevrolet);
                    break;

                case "Citroen":
                    brandEnumType = typeof(Citroen);
                    break;

                case "Dacia":
                    brandEnumType = typeof(Dacia);
                    break;

                case "Daewoo":
                    brandEnumType = typeof(Daewoo);
                    break;

                case "Dodge":
                    brandEnumType = typeof(Dodge);
                    break;

                case "Ferrari":
                    brandEnumType = typeof(Ferrari);
                    break;

                case "Fiat":
                    brandEnumType = typeof(Fiat);
                    break;

                case "Ford":
                    brandEnumType = typeof(Ford);
                    break;

                case "Honda":
                    brandEnumType = typeof(Honda);
                    break;

                case "Hummer":
                    brandEnumType = typeof(Hummer);
                    break;

                case "Hyundai":
                    brandEnumType = typeof(Hyundai);
                    break;

                case "Infiniti":
                    brandEnumType = typeof(Infiniti);
                    break;

                case "Iveco":
                    brandEnumType = typeof(Iveco);
                    break;

                case "Jaguar":
                    brandEnumType = typeof(Jaguar);
                    break;

                case "Jeep":
                    brandEnumType = typeof(Jeep);
                    break;

                case "Maybach":
                    brandEnumType = typeof(Maybach);
                    break;

                case "Mazda":
                    brandEnumType = typeof(Mazda);
                    break;

                case "McLaren":
                    brandEnumType = typeof(McLaren);
                    break;

                case "Mercedes Benz":
                    brandEnumType = typeof(MercedesBenz);
                    break;

                case "Mini":
                    brandEnumType = typeof(Mini);
                    break;

                case "Nissan":
                    brandEnumType = typeof(Nissan);
                    break;

                case "Opel":
                    brandEnumType = typeof(Opel);
                    break;

                case "Peugeot":
                    brandEnumType = typeof(Peugeot);
                    break;

                case "Pontiac":
                    brandEnumType = typeof(Pontiac);
                    break;

                case "Porsche":
                    brandEnumType = typeof(Porsche);
                    break;

                case "Renault":
                    brandEnumType = typeof(Renault);
                    break;

                case "Rolls Royce":
                    brandEnumType = typeof(RollsRoyce);
                    break;

                case "Skoda":
                    brandEnumType = typeof(Skoda);
                    break;

                case "Subaru":
                    brandEnumType = typeof(Subaru);
                    break;

                case "Tesla":
                    brandEnumType = typeof(Tesla);
                    break;

                case "Toyota":
                    brandEnumType = typeof(Toyota);
                    break;

                case "Volvo":
                    brandEnumType = typeof(Volvo);
                    break;
            }

            var options = Enum.GetNames(brandEnumType).Select(m =>
            {
                var probableValue = Enum.Parse(brandEnumType, m);
                return new SelectListItem() { Text = m.Replace("_", " "), Value = ((int)probableValue).ToString() };
            });

            return Json(options, JsonRequestBehavior.AllowGet);
        }

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

