using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models.BrandModelEnums
{
    public enum MercedesBenz
    {
        [Display(Name = "A45 AMG")]
        A_45_AMG,
        [Display(Name = "C65 AMG")]
        C_65_AMG,
        [Display(Name = "E65 AMG")]
        E_65_AMG,
        [Display(Name = "S65 AMG")]
        S_65_AMG
    }
}