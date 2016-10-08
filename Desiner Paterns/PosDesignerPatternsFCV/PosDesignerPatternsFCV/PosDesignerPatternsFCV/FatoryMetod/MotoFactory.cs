using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.FatoryMetod
{
    class MotoFactory
    {

        public MotoFactory()
        {
        }


        //Method factory
        public IMoto FabricarMotos(EMotos en)
        {
            switch (en)
            {
                case EMotos.BMW:
                    return new MotoBMW();
                case EMotos.HONDA:
                    return new MotoHonda();
                case EMotos.NINJA:
                    return new MotoNinja();
                case EMotos.YBR:
                    return new MotoYBR();
                default:
                    return null;
            }
        }
    }
}
