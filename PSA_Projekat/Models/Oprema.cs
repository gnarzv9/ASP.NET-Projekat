using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PSA_Projekat.Models
{
    public class Oprema
    {
        [Key]
        public int Sifra { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Naziv { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Proizvodjac { get; set; }

        [Column(TypeName = "INT")]
        public int Kolicina { get; set; }

        [Column(TypeName = "INT")]
        public int TezinaKilograms { get; set; }
    }
}