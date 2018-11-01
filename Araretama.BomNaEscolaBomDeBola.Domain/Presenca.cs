using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Araretama.BomNaEscolaBomDeBola.Domain
{
    public class Presenca
    {

        public int id { get; set; }

        [Required]
        [DisplayName("Codigo")]
        public int codigo { get; set; }

        [Required]
        [DisplayName("Aluno")]
        public Aluno aluno { get; set; }

        [Required]
        [DisplayName("Presença")]
        public bool presente { get; set; }
    }
}