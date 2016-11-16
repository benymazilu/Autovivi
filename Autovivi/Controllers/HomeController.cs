using Autovivi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Autovivi.Controllers
{
    public class HomeController : Controller
    {
        private AutoviviDbContext db = new AutoviviDbContext();

        public ActionResult Index()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Results(SearchOptions options)
        {
            var allVehiclesQuery = db.Adds.AsQueryable();
            if (options.VehicleType != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.VehicleType == options.VehicleType);
            if (options.Brand != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.Brand == options.Brand);
            if (options.Price > 0) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.Price <= options.Price);
            if (options.Mileage > 0) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.Mileage <= options.Mileage);
            if (options.Model != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.Model == options.Model);
            if (options.FuelType != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.FuelType == options.FuelType);
            if (options.ProductionYear != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.ProductionYear == options.ProductionYear);
            if (options.Condition != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.Condition == options.Condition);
            return View(allVehiclesQuery.ToList());
        }

        public ActionResult DetailedResults(DetailedSearchOptions options)
        {
            var allVehiclesQuery = db.Adds.AsQueryable();
            if (options.VehicleType != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.VehicleType == options.VehicleType);
            if (options.Brand != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.Brand == options.Brand);
            if (options.Price > 0) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.Price <= options.Price);
            if (options.Mileage > 0) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.Mileage <= options.Mileage);
            if (options.Model != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.Model == options.Model);
            if (options.FuelType != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.FuelType == options.FuelType);
            if (options.ProductionYear != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.ProductionYear == options.ProductionYear);
            if (options.Condition != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.Condition == options.Condition);
            if (options.BodyStyle != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.BodyStyle == options.BodyStyle);
            if (options.GearBox != null) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.GearBox == options.GearBox);
            if (options.CubicCapacity > 0) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.CubicCapacity <= options.CubicCapacity);
            if (options.Power > 0) allVehiclesQuery = allVehiclesQuery.Where(a => a.Vehicle.Power <= options.Power);

            return View(allVehiclesQuery.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

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
    }
}