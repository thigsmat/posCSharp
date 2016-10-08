using Site1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Site1.ViewModels
{
    public class VeiculoViewModel
    {
        public Marca Marca { get; set; }
        public Veiculo Veiculo { get; set; }

        [Display(Name = "Estado de Uso")]
        public EstadoDeUso EstadoDeUso { get; set; }
    }

    public enum EstadoDeUso
    {
        Novo,
        Usado,
        Batido
    }
}