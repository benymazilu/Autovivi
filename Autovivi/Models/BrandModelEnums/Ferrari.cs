using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models.BrandModelEnums
{
    public enum Ferrari
    {   
        Berlinetta,
        [Display(Name ="458 Italia")]
        _458,
        F12,
        [Display(Name ="La Ferrari")]
        LaFerrari,
        Testarossa
        
    }
}