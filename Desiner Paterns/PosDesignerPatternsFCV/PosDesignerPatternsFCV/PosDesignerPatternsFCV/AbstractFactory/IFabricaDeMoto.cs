using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.AbstractFactory
{
    interface IFabricaDeMoto
    {
        IMotoDeLuxo CriarMotoDeLuxo();

        IMotoPopular CriarMotoPopular();
    }
}
