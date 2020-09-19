using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialPaulAguilar.Models
{
     public enum Continentes
    {
        America,Europa, Oceania, Asia, Africa

    }
    public class Paises
    {
        [MaxLength(3)]
        public string alpha3Code { get; set; }
        public Continentes region { get; set; }
        [Key]
        [StringLength(20, ErrorMessage ="Introducir nombre de pais correcto, no más de 20 letras permitidas ni menos de 5"), MinLength(5)]
        public string name { get; set; }
        public int area { get; set; }
        public int callingCodes { get; set; }
        public string languages { get; set; }
        public string flag { get; set; }
    }
}