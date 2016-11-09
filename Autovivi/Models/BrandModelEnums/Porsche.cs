using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models.BrandModelEnums
{
    public enum Porsche
    {
        [Display(Name = "911")]
        _911,
        Cayenne,
        Cayman,
        Panamera
    }
}