using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models.BrandModelEnums
{
    public enum Tesla
    {
        [Display(Name = "Model 3")]
        Model3,
        [Display(Name = "Model S")]
        ModelS,
        [Display(Name = "Model X")]
        Modelx
    }
}