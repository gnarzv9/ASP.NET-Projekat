using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSA_Projekat.Models
{
    public class Sportista
    {
        [Required, MinLength(2), MaxLength(25)]
        public string Ime { get; set; }

        [Required, MinLength(2), MaxLength(25)]
        public string Prezime { get; set; }

        public string Pol { get; set; }

        [Required]
        public string Clanarina { get; set; }
    }
}