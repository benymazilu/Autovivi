using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        public Brand Brand { get; set; }

        public string Model { get; set; }

        public int ProductionYear { get; set; }

        public string FuelType { get; set; }

        public VehicleType VehicleType { get; set; }

        public decimal Price { get; set; }

        public int Mileage { get; set; }

        public int CubicCapacity { get; set; }

        public string Condition { get; set; }

        public string Damage { get; set; }

        public string Description { get; set; }

        public string CountryOrigin { get; set; }

        public string Colour { get; set; }

        public string GearBox { get; set; }

        public int Power { get; set; }

        public string Options { get; set; }

        public string BodyStyle { get; set; }



    }
}