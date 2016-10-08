using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.FatoryMetod.Atividade_desafio_II
{
    class ConcreteVeiculoFactory : VeiculoFactory
    {
        public override IFactory GetVeiculo(string veic)
        {
            switch (veic)
            {
                case "bike":
                    return new Bicicleta();
                case "scooter":
                    return new Scooter();
                default:
                    return null;
            }
        }
    }
}
