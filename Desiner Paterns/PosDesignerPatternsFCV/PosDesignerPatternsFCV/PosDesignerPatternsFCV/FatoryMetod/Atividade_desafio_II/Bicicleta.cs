using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.FatoryMetod.Atividade_desafio_II
{
    public class Bicicleta : IFactory
    {
        public void Dirigir()
        {
            Console.WriteLine("Dirigindo bicicleta");
        }
    }
}
