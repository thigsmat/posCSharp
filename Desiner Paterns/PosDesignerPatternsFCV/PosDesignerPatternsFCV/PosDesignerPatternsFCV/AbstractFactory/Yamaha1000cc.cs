using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.AbstractFactory
{
    class Yamaha1000cc : IMotoDeLuxo
    {
        public void ExibirInfoLuxo()
        {
            Console.WriteLine("Yamaha1000cc, Luxo");
        }
    }
}
