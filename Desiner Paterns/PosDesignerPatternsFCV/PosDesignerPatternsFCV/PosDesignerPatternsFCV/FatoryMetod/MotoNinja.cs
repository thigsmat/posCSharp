using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.FatoryMetod
{
    public class MotoNinja :IMoto
    {
        public MotoNinja()
        {
           
        }

        public string ExibirModelo()
        {
            Console.WriteLine("MotoNinja");
            return "";
        }
    }
}
