using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Araretama.BomNaEscolaBomDeBola.Domain
{
    public class Aula
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Data da Aula")]
        [DataType(DataType.Date)]
        public DateTime DataAula{ get; set; }

        [Required]
        [DisplayName("Data do envio")]
        [DataType(DataType.DateTime)]
        public DateTime DataEnvio { get; set; }

        [Required]
        [DisplayName("Presenças")]
        public List<Presenca> Presencas { get; set; }

        [Required]
        [DisplayName("Horário")]
        public DateTime Horario { get; set; }

        [DisplayName("Turma")]
        public Turma Turma { get; set; }

        [DisplayName("Turma")]
        public int IDTurma { get; set; }

    }
}