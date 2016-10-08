using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfAtiv_I
{
    public class ServicoFuncionario : IFuncionario
    {
        private RepositorioFuncionario repFunc;

        public ServicoFuncionario()
        {
            repFunc = new RepositorioFuncionario();
        }
        public List<Funcionario> ListarFuncionario()
        {
            return repFunc.ListarFuncionario();
        }

        public Funcionario SelecioarFuncionario(int id)
        {
            return repFunc.SelecioarFuncionario(id);
        }
    }
}
