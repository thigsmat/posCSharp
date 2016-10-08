using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.FatoryMetod
{
    public class MotoYBR : IMoto
    {
        public MotoYBR() {
           
        }

        public string ExibirModelo()
        {
            Console.WriteLine("MotoYBR");
            return "";
        }
    }
}
