using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.FatoryMetod.Atividade_desafio
{
    public class Pizzaiolo : Cozinheiro
    {
        public override void cozinhar()
        {
            Console.WriteLine("Assando Pizza");
        }

        public override Comida criaComida()
        {
            return new Pizza();
        }
    }
}
