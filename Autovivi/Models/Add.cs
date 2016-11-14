using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models
{
    public class Add 
    {
        [Key]
        public int Id { get; set; }

        public virtual User User { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public virtual List<Message> Messages { get; set; }

        public DateTime PostDate { get; set; }

       
    }
}