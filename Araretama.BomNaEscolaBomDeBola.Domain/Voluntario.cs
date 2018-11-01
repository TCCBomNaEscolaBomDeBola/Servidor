﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Araretama.BomNaEscolaBomDeBola.Domain
{
    public class Voluntario
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "O nome deve ser informado")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O login deve ser informado")]
        [DisplayName("Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A senha deve ser informado")]
        [DisplayName("Senha")]
        public string Senha { get; set; }

       // [Required]
        [DisplayName("Email")]
        public string Email { get; set; }

      //  [Required]
        [DisplayName("Contato")]
        public string Contato { get; set; }

    }
}