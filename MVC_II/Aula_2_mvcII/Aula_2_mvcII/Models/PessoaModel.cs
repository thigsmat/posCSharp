using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula_2_mvcII.Models
{
    public class PessoaModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}