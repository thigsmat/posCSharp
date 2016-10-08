using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.FatoryMetod.Atividade_desafio
{
    public abstract class Cozinheiro
    {
        public abstract void cozinhar();
        public abstract Comida criaComida();
    }
}
