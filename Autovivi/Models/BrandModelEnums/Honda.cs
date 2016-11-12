using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models.BrandModelEnums
{
    public enum Honda
    {
        Accord,
        Civic,
        [Display(Name = "Civic Type R")]
        Civic_Type_R,
        CB125,
        CBR,
        CB400,

    }
}