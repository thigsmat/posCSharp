using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.FatoryMetod
{
    public class FabricaHonda : Fabrica
    {
        public override IMoto FabricarMotos()
        {
            return new MotoHonda();
        }
    }
}
