using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosDesignerPatternsFCV.Singleton
{
    class ConexaoSingleton
    {
        private static ConexaoSingleton _instancia;

        protected ConexaoSingleton(){}

        public static ConexaoSingleton GetConexao()
        {
            if (_instancia == null)
                _instancia = new ConexaoSingleton();

            return _instancia;
        }
    }
}
