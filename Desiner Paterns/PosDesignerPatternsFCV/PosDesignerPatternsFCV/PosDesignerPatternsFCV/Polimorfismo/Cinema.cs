using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.Polimorfismo
{
    class Cinema
    {
        public void EntrarNoCinema(IBilhete bilhete)
        {
            if (bilhete.Validar())
                Console.WriteLine("Entrou no cinem");
            else
              Console.WriteLine("Nao pode assistir porcaria");
        }
    }
}
