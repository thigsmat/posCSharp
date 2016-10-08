using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Site1.Models
{
    public class Marca
    {
        [Column("Id")]
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }
        public string Pais { get; set; }
    }
}