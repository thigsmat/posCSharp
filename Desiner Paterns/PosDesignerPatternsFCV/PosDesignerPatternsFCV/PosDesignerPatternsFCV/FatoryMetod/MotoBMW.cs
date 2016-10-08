using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.FatoryMetod
{
    public class MotoBMW : IMoto
    {
        public MotoBMW()
        {
           
        }

        public string ExibirModelo()
        {
            Console.WriteLine("MotoBMW");
            return "";
        }
    }
}
