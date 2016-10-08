using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.Polimorfismo
{
    class Crepusculo : IBilhete
    {
        public bool Validar()
        {
            Console.WriteLine("Validando Crepusculo");
            return false;
        }
    }
}
