using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Autovivi.Models
{
    public class SearchOptions
    {
        public Brand? Brand { get; set; }

        public string Model { get; set; }

        public ProductionYear? ProductionYear { get; set; }

        public FuelType? FuelType { get; set; }

        public VehicleType? VehicleType { get; set; }

        public decimal Price { get; set; }

        public int Mileage { get; set; }

        public Condition? Condition { get; set; }

        public virtual List<BrandModel> Models { get; set; }
    }
}