using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models
{
    public enum Condition
    {
        [Display(Name ="New Car")]
        NewCar,
        [Display(Name ="Used Car")]
        UsedCar
    }
}