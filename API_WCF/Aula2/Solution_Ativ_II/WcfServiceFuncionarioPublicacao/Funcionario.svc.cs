using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceFuncionarioPublicacao
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Funcionario" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Funcionario.svc or Funcionario.svc.cs at the Solution Explorer and start debugging.
    public class Funcionario : IFuncionario
    {
        private RepositorioFuncionario repFunc;

        public Funcionario()
        {
            repFunc = new RepositorioFuncionario();
        }
        public List<FuncionarioType> ListarFuncionario()
        {
            return repFunc.ListarFuncionario();
        }

        public FuncionarioType SelecioarFuncionario(int id)
        {
            return repFunc.SelecioarFuncionario(id);
        }

        public List<FuncionarioType> SelecioarFuncionarioPorNome(string nome)
        {
            return repFunc.SelecioarFuncionarioPorNome(nome);
        }
    }
}
