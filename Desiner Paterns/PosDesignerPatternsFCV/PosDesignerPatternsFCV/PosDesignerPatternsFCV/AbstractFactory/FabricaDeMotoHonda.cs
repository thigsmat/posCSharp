using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.AbstractFactory
{
    class FabricaDeMotoHonda : IFabricaDeMoto
    {
        public IMotoDeLuxo CriarMotoDeLuxo()
        {
            return new Honda1000cc();
        }

        public IMotoPopular CriarMotoPopular()
        {
            return new HondaBiz();
        }
    }
}
