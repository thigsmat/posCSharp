using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AplicacaoWebService1
{
    /// <summary>
    /// Summary description for PrimeiroServico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PrimeiroServico : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<string> CarregaAlunos()
        {
            return new List<string> {
                                        "Maria",
                                        "Jusé",
                                        "Juão"
                                    };
        }

        [WebMethod]
        public string CadastrarAluno(string nome)
        {
            return "Cadastrado com sucesso! "+nome;
        }
    }
}
