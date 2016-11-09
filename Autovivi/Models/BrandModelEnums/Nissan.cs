using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models.BrandModelEnums
{
    public enum Nissan
    {
        GTR,
        [Display(Name = "350Z")]
        _350Z,
        [Display(Name = "370Z")]
        _370Z
    }
}