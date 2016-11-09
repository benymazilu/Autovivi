using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models.BrandModelEnums
{
    public enum Iveco
    {
        Eurostar,
        Stralis,
        [Display(Name = "Stralis Mega")]
        StralisMega
    }
}