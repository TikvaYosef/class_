using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace class_.Models
{
    public class Employyes
    {
        [Required]
        public int Id {set; get; }
        public string Class_ { set;get; }
        public int NumOfEmployyes { set; get; }


    }
}