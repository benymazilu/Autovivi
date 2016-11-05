using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models
{
    public enum Brand
    {
        Audi,
        [Display(Name = "Alfa Romeo")]
        AlfaRomeo,
        Acura,
        Bentley,
        BMW,
        Cadillac,
        Chevrolet,
        Citroen,
        Dacia,
        Daewoo,
        Dodge,
        Ferrari,
        Fiat,
        Ford,
        Honda,
        Hummer,
        Hyundai,
        Infinti,
        Iveco,
        Jaguar,
        Jeep,
        Maybach,
        Mazda,
        McLaren,
        [Display(Name = "Mercedes Benz")]
        MercedesBenz,
        Mini,
        Nissan,
        Opel,
        Peugeot,
        Pontiac,
        Porsche,
        Renault,
        [Display(Name = "Rolls Royce")]
        RollsRoyce,
        Skoda,
        Subaru,
        Tesla,
        Toyota,
        Volvo
    }
}