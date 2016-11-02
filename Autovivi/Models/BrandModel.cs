using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models
{
    public class BrandModel
    {
        [Key]
        public int Id { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public string CarModel { get; set; }
    }
}