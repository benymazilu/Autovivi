using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models.BrandModelEnums
{
    public enum Mini
    {
        [Display(Name = "Cooper S")]
        Cooper_S,
        Clubman,
        [Display(Name = "John Cooper Works")]
        John_Cooper_Works
        
    }
}