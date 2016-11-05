using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models
{
    public enum BodyStyle
    {
        Cabrio,
        Coupe,
        Estate,
        Saloon,
        [Display(Name = "Small Car")]
        SmallCar,
        Van

    }
}