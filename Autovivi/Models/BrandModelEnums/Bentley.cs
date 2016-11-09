using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models.BrandModelEnums
{
    public enum Bentley
    {   
        Continental,
        [Display(Name = "Continental Flying Spur")]
        ContientalFlyingSpur,
        GTC,
        Mulsanne
    }
}