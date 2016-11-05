using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models
{
    public enum Gearbox
    {
        [Display(Name = "Manual Gearbox")]
        ManualGearbox,
        [Display(Name = "Automatic Gearbox")]
        AutomaticGearbox,
        [Display(Name = "Semi-Automatic Gearbox")]
        SemiAutomaticGearbox
    }
}