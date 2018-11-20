using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Araretama.BomNaEscolaBomDeBola.Domain
{
    public class Presenca
    {
        [Required]
        [DisplayName("Codigo")]
        public int id { get; set; }

        [Required]
        [DisplayName("Aluno")]
        public Aluno Aluno { get; set; }

        [Required]
        [DisplayName("Aluno")]
        public int IDAluno { get; set; }

        [Required]
        [DisplayName("Presença")]
        public bool Presente { get; set; }

        [Required]
        [DisplayName("Aula")]
        public int IDAula { get; set; }
    }
}