using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.AbstractFactory
{
   public class YBR : IMotoPopular
    {
        public void ExibirInfoPopular()
        {
            Console.WriteLine("YBR, Popular");
        }
    }
}
