using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfFuncionarioRest
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

        public FuncionarioType SelecioarFuncionario(string id)
        {
            return repFunc.SelecioarFuncionario(Convert.ToInt16(id));
        }

        public bool AddFuncionario(string id, string nome, string salario)
        {
            return repFunc.AddFuncionario(new FuncionarioType()
            {
                Id = Convert.ToInt32(id),
                Nome = nome,
                Salario = Convert.ToDouble(salario),
                DataCadastro = DateTime.Now
            });
        }

        public List<FuncionarioType> SelecioarFuncionarioPorNome(string nome)
        {
            return repFunc.SelecioarFuncionarioPorNome(nome);
        }
    }
}
