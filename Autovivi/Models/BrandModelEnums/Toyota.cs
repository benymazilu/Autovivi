using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models.BrandModelEnums
{
    public enum Toyota
    {
        GT86,
        Supra,
        [Display(Name = "Land Cruiser")]
        Land_Cruiser
    }
}