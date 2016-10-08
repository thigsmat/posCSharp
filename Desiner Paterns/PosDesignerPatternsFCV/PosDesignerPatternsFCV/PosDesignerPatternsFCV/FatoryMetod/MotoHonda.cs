using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.FatoryMetod
{
    public class MotoHonda : IMoto
    {
        public MotoHonda()
        {
           
        }

        public string ExibirModelo()
        {
            Console.WriteLine("MotoHonda");
            return "";
        }
    }
}
