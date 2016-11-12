using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models.BrandModelEnums
{
    public enum Jeep
    {
        Cherokee,
        [Display(Name = "Grand Cherokee")]
        Grand_Cherokee,
        Renegade,
        Wrangler
    }
}