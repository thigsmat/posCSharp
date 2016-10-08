using Site1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site1.ViewModel
{
    public class VeiculoViewModel
    {
        public Marca Marca { get; set; }
        public Veiculo Veiculo { get; set; }
        public EstadoDeUso EstadoDeUso { get; set; }
    }

    public enum EstadoDeUso
    {
        Novo,
        Usado,
        Batido
    }
}