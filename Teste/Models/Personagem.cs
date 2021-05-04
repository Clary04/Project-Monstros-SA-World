using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    public class Personagem
    {
        [Key]
       public int Id { get; set; }
        [DisplayName("Nome do Personagem")]
        [Required]
        public string PersonagemName { get; set; }
        [DisplayName("Cenário")]
        [Required]
        public string Cenario{ get; set; }

    }
}
