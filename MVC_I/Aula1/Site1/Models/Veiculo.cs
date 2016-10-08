using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Site1.Models
{
    public class Veiculo
    {
        public int Id { get; set; }

        public bool Ativo { get; set; }

        [Required]
        [Range(1950, 2016, ErrorMessage = "O {0} deve estar entre {1} e {2}")]
        public int Ano { get; set; }

        [Required]
        [StringLength(30)]
        public string Modelo { get; set; }
        public decimal Preco { get; set; }

        [Required]
        [Display(Name = "Marca")]
        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
    }
}