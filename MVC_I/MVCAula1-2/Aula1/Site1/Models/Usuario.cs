using Site1.Models.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site1.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Remote("LoginValido", "Usuarios")]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required, DataType(DataType.Password), System.ComponentModel.DataAnnotations.Compare("Senha")]
        public string ConfirmarSenha { get; set; }

        [Required, Cpf(ErrorMessage = "O campo {0} está inválido!")]
        [UIHint("Cpf")] // chama o EditorTemplate adequado
        public string Cpf { get; set; }

        [Display(Name = "Data de nascimeto")]
        public DateTime DataNascimento { get; set; }
    }
}