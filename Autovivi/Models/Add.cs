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

<<<<<<< HEAD
        //public DateTime PostDate { get; set; }
=======
        public DateTime PostDate { get; set; }

       
>>>>>>> 39343b8df21a31b5e6e07f1c1d542d7c682fb9b8
    }
}