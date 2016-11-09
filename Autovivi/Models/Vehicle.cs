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

        public Brand? Brand { get; set; }

        public string Model { get; set; }

        public ProductionYear? ProductionYear { get; set; }

        public FuelType? FuelType { get; set; }

        public VehicleType? VehicleType { get; set; }

        public decimal Price { get; set; }

        public int Mileage { get; set; }

        public int CubicCapacity { get; set; }

        public Condition? Condition { get; set; }

        public string Damage { get; set; }

        public string Description { get; set; }

        public string CountryOrigin { get; set; }

        public string Colour { get; set; }

        public Gearbox? GearBox { get; set; }

        public int Power { get; set; }

        public Options Options { get; set; }

        public BodyStyle? BodyStyle { get; set; }
        
        public virtual List<BrandModel> Models { get; set; }
    }
}