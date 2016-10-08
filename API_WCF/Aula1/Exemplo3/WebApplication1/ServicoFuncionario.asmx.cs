using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for ServicoFuncionario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class ServicoFuncionario : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Funcionario> CarregaFuncionario()
        {
            return new List<Funcionario>() {
                new Funcionario() {Id=1,Nome="Tiao Galinha",Salario=203.30,DataCadastro=DateTime.Now },
                new Funcionario() {Id=2,Nome="Visconde Sabugosa",Salario=303.30 ,DataCadastro=DateTime.Now},
                new Funcionario() {Id=3,Nome="Patolino",Salario=403.30 ,DataCadastro=DateTime.Now},
                new Funcionario() {Id=4,Nome="Hortelino",Salario=503.30 ,DataCadastro=DateTime.Now},
                new Funcionario() {Id=5,Nome="Pernalonga",Salario=603.30 ,DataCadastro=DateTime.Now},
                new Funcionario() {Id=6,Nome="Zé buscape",Salario=703.30 ,DataCadastro=DateTime.Now}
            };
        }

        [WebMethod]
        public Funcionario SelecionarFuncionario(int id)
        {
            if (id == 0) {
                return null;
            }
            return CarregaFuncionario().Find(x=>x.Id==id);
        }
        }
}
