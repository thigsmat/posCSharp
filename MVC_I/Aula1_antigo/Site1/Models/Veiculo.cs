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
        //[Key]  // idendifica a chave da tabela
        [Column("Id")] //=Qualquer nome
        public int Id { get; set; }

        [Required]
        [Range(1950, 2016)]
        [Display(Name = "Ano")]
        public int Ano { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Required]
        [Display(Name = "Marca")]
        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }

    }
}