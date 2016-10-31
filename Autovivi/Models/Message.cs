using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Autovivi.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        public string Messages { get; set; }

        public virtual User Sender { get; set; }

        public virtual User Receiever { get; set; }

        public virtual Add Add { get; set; }
        
    }
}