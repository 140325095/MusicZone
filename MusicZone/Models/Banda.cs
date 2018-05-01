using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MusicZone.Models
{
    public class Banda
    {
        [Required (ErrorMessage ="Preencha Corretamente o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha Corretamente numero")]
        public int? Numeroelementos { get; set; }
        public string Genero { get; set; }
        public bool Top { get; set; }
    }
}
