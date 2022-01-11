using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace class_.Models
{
    public class Company
    {
        [Required]
        public int Id { get; set; }
        public string City { get; set; }
        public string NameOfCompany { get; set; }
    }
}