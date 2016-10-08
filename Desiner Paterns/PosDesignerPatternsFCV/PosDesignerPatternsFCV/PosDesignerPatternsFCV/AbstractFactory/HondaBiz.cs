using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.AbstractFactory
{
    public class HondaBiz : IMotoPopular
    {
        public void ExibirInfoPopular()
        {
            Console.WriteLine("BIZ, Popular");
        }
    }
}
