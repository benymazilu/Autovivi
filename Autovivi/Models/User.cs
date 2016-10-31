using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Autovivi.Models
{
    public class User : Person
    {

        public virtual List<Add> Adds { get; set; }

        public virtual List<Message> Messages{ get; set; }
    }
}