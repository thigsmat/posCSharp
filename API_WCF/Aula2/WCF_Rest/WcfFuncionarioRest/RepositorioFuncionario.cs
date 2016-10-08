using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfFuncionarioRest
{
    public class RepositorioFuncionario
    {
        public RepositorioFuncionario()
        {

            listaFuncionario = new List<FuncionarioType>(){
                new FuncionarioType() { Id=1,Nome="Zé da Pinga1", Salario=1.00,DataCadastro=DateTime.Now},
                new FuncionarioType() { Id=2,Nome="Zé da Pinga2", Salario=2.00,DataCadastro=DateTime.Now},
                new FuncionarioType() { Id=3,Nome="Zé da Pinga3", Salario=3.00,DataCadastro=DateTime.Now},
                new FuncionarioType() { Id=4,Nome="Zé da Pinga4", Salario=4.00,DataCadastro=DateTime.Now},
                new FuncionarioType() { Id=5,Nome="Zé da Pinga5", Salario=5.00,DataCadastro=DateTime.Now},
                new FuncionarioType() { Id=6,Nome="Zé da Pinga6", Salario=6.00,DataCadastro=DateTime.Now},
                new FuncionarioType() { Id=7,Nome="Zé da Pinga7", Salario=7.00,DataCadastro=DateTime.Now}
           };
        }

        private static List<FuncionarioType> listaFuncionario;

        public List<FuncionarioType> ListarFuncionario()
        {
            return listaFuncionario;
        }

        public FuncionarioType SelecioarFuncionario(int id)
        {
            return listaFuncionario.Find(x => x.Id == id);
        }

        public List<FuncionarioType> SelecioarFuncionarioPorNome(string nome)
        {
            return listaFuncionario.FindAll(x => x.Nome.Contains(nome));
        }

        public bool AddFuncionario(FuncionarioType funcionario)
        {
            if (funcionario != null)
            {
                 listaFuncionario.Add(funcionario);
                return true;
            }
            return false;
        }
    }
}
