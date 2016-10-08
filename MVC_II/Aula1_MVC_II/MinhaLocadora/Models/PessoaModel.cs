using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinhaLocadora.Models
{
    public class PessoaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public ICollection<CarroModel> Carros { get; set; }
    }
}