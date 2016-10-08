using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.AbstractFactory
{
    class FabricaMotoYamaha : IFabricaDeMoto
    {
        public IMotoDeLuxo CriarMotoDeLuxo()
        {
            return new Yamaha1000cc();
        }

        public IMotoPopular CriarMotoPopular()
        {
            return new YBR();
        }
    }
}
