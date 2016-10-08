using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.AbstractFactory
{
    public class Honda1000cc : IMotoDeLuxo
    {
        public void ExibirInfoLuxo()
        {
            Console.WriteLine("Honda1000cc, Luxo");
        }
    }
}
