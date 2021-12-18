using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class ClassInsu
    {
        [Required]
        public int masEdad { get; set; }
        public int Modelo { get; set; }

    }
}