using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfAtiv_I
{
    public class RepositorioFuncionario
    {
        public RepositorioFuncionario()
        {

            listaFuncionario = new List<Funcionario>(){
                new Funcionario() { Id=1,Nome="Zé da Pinga1", Salario=1.00,DataCadastro=DateTime.Now},
                new Funcionario() { Id=2,Nome="Zé da Pinga2", Salario=2.00,DataCadastro=DateTime.Now},
                new Funcionario() { Id=3,Nome="Zé da Pinga3", Salario=3.00,DataCadastro=DateTime.Now},
                new Funcionario() { Id=4,Nome="Zé da Pinga4", Salario=4.00,DataCadastro=DateTime.Now},
                new Funcionario() { Id=5,Nome="Zé da Pinga5", Salario=5.00,DataCadastro=DateTime.Now},
                new Funcionario() { Id=6,Nome="Zé da Pinga6", Salario=6.00,DataCadastro=DateTime.Now},
                new Funcionario() { Id=7,Nome="Zé da Pinga7", Salario=7.00,DataCadastro=DateTime.Now}
           };
        }

        private static List<Funcionario> listaFuncionario;

        public List<Funcionario> ListarFuncionario()
        {
            return listaFuncionario;
        }

        public Funcionario SelecioarFuncionario(int id)
        {
            return listaFuncionario.Find(x => x.Id == id);
        }
    }
}
