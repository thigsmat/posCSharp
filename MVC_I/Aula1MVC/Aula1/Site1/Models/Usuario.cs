using Site1.Models.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Site1.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [System.Web.Mvc.Remote("LoginInvalido", "Usuarios")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        [DataType(DataType.Password), System.ComponentModel.DataAnnotations.Compare("Senha")]
        public string ConfirmaSenha { get; set; }

        [Required,Cpf(ErrorMessage = "Teste")]
        [UIHint("Cpf")] //chamar o editor do template
        public string Cpf { get; set; }
    }
}